using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class ProcesHurtZamowienie : Form
    {
        MGREntities db;
        public ProcesHurtZamowienie(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cbStanRealizacjiData();
        }
        private void showDealData()
        {
            this.db = new MGREntities();
            this.dgvDeal.DataSource = this.db.v_Umowa_sprzedazy_hurt.OrderBy(a => a.Numer_umowy_sprzedazy).ToList();
            dgvDeal.Columns[1].Visible = false;
            this.dgvDeal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showOrderData()
        {
            this.db = new MGREntities();
            this.dgvOrders.DataSource = this.db.v_Zamowienie.OrderBy(a => a.Numer_zamowienia).ToList();
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showData()
        {
            showOrderData();
            showDealData();
        }

        private void cbStanRealizacjiData()
        {
            cbStanRealizacji.DataSource = this.db.Stan_realizacji.ToList();
            cbStanRealizacji.ValueMember = "ID_stan_realizacji";
            cbStanRealizacji.DisplayMember = "Nazwa_stan_realizaji";
        }

        private void dgvDeal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDealNo.Text = this.dgvDeal.CurrentRow.Cells[0].Value.ToString();
            tbClientName.Text = this.dgvDeal.CurrentRow.Cells[2].Value.ToString();
            tbClientSurname.Text = this.dgvDeal.CurrentRow.Cells[3].Value.ToString();
            tbWorkerName.Text = this.dgvDeal.CurrentRow.Cells[4].Value.ToString();
            tbWorkerSurname.Text = this.dgvDeal.CurrentRow.Cells[5].Value.ToString();
            tbOfferNo.Text = this.dgvDeal.CurrentRow.Cells[1].Value.ToString();
        }
        private void searchNumber()
        {
            try
            {
                int selecedDealIdInt = int.Parse(tbNumber.Text);
                List<Umowa_sprzedaz_hurt> searchDealtNo = db.Umowa_sprzedaz_hurt.Where(a => a.ID_umowa_sprzedaz_hurt == selecedDealIdInt).ToList();
                if (searchDealtNo.Count() > 0)
                {
                    this.dgvDeal.DataSource = searchDealtNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer umowy: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru umowy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbNumber.Clear();
        }
        private void msgCleanShowData(string searchKlient)
        {
            messageBox(searchKlient);
            cleanTextBox();
            showDealData();
        }
        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbNumber.Text.Length > 0)
                choose = "Number";
            switch (choose)
            {
                case "Number":
                    searchNumber();
                    break;
                default:
                    wrongData();
                    break;
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showDealData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDealData();
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbClientName.Text) || String.IsNullOrEmpty(tbClientSurname.Text) || String.IsNullOrEmpty(tbDealNo.Text) 
                || String.IsNullOrEmpty(tbWorkerName.Text) || String.IsNullOrEmpty(tbWorkerSurname.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Klient selectedClient = this.db.Klient.SingleOrDefault(a => a.Nazwisko == tbClientSurname.Text && a.Imie == tbClientName.Text);
                Pracownik selectedPracownik = this.db.Pracownik.SingleOrDefault(b => b.Nazwisko == tbWorkerSurname.Text && b.Imie == tbWorkerName.Text);
                int selectedStanINT = int.Parse(cbStanRealizacji.SelectedValue.ToString());
                int selectedDealINT = int.Parse(tbDealNo.Text);
                Zamowienie newzamowienie = new Zamowienie();
                newzamowienie.Data_zamowienie = dtpDateorder.Value.Date;
                newzamowienie.ID_pracownik = selectedPracownik.ID_pracownik;
                newzamowienie.ID_klient = selectedClient.ID_klient;
                newzamowienie.ID_stan_realizaji = selectedStanINT;
                newzamowienie.ID_umowa_sprzedaz_hurt = selectedDealINT;
                newzamowienie.ID_oferta_handlowa = int.Parse(tbOfferNo.Text);
                this.db.Zamowienie.Add(newzamowienie);
                this.db.SaveChanges();
                MessageBox.Show("Skonstruowano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOfferDetailsBeforeAgain = this.db.Zamowienie_szczegol.Count();
                MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcesHurtZamowienieDetails procesHurtZamowienieDetails = new ProcesHurtZamowienieDetails(db, newzamowienie);
                procesHurtZamowienieDetails.ShowDialog();
                int counterOfferDetailsAfterAgain = this.db.Zamowienie_szczegol.Count();
                if (counterOfferDetailsAfterAgain > counterOfferDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano zamówienie", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły zamówienia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvOrders.CurrentRow.Cells[0].Value.ToString());
            Zamowienie selectedOrder = this.db.Zamowienie.Single(a => a.ID_zamowienie == selectedOrderDetails);
            ProcesHurtZamowienieDetails procesHurtOfertaHandlowaDetails = new ProcesHurtZamowienieDetails(db, selectedOrder);
            procesHurtOfertaHandlowaDetails.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvOrders.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć zamówienie?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Zamowienie selectedOferta = this.db.Zamowienie.Single(a => a.ID_zamowienie == salesDetailNo);
                    this.db.Zamowienie.Remove(selectedOferta);
                    List<Zamowienie_szczegol> selectOfferdetails = this.db.Zamowienie_szczegol.Where(a => a.ID_zamowienie == salesDetailNo).ToList();
                    this.db.Zamowienie_szczegol.RemoveRange(selectOfferdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
