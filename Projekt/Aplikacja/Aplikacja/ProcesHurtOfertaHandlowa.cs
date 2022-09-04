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
    public partial class ProcesHurtOfertaHandlowa : Form
    {
        MGREntities db;
        public ProcesHurtOfertaHandlowa(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            cbPracownikData();
            cbStatusData();
            showData();
            selectStatus();
        }

        private void cbPracownikData()
        {
            cbPracownik.DataSource = this.db.v_Pracownik_stanowisko.Where(a=>a.Stanowisko == "Sprzedawca" || a.Stanowisko == "Handlowiec").ToList();
            cbPracownik.ValueMember = "ID_pracownik";
            cbPracownik.DisplayMember = "Nazwisko";
        }

        private void cbStatusData()
        {
            cbStatus.DataSource = this.db.Status_oferta.ToList();
            cbStatus.ValueMember = "ID_status_oferta";
            cbStatus.DisplayMember = "Nazwa_status_oferta";
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvOffers.DataSource = this.db.v_Oferta_handlowa.OrderBy(a => a.Numer_oferty).ToList();
            this.dgvOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cleanTextBox()
        {
            tbOfferNumber.Clear();
        }

        private void msgCleanShowData(string searchSalesNo)
        {
            messageBox(searchSalesNo);
            cleanTextBox();
            showData();
        }
        private void selectStatus()
        {
            if (checkBox1.Checked)
            {
                this.db = new MGREntities();
                this.dgvOffers.DataSource = this.db.v_Oferta_handlowa_zaakceptowane.OrderBy(a => a.Numer_oferty).ToList();
                this.dgvOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                showData();
            }
        }

        private void messageBox(string searchSalesNo)
        {
            MessageBox.Show($"{searchSalesNo} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            selectStatus();
            string choose = "";
            if (tbOfferNumber.Text.Length > 0)
                choose = "Number";
                switch (choose)
            {
                case "Number":
                    searchNumber();
                    break;
            }
        }

        private void searchNumber()
        {
            try
            {
                int selectedNoint = int.Parse(tbOfferNumber.Text);
                List<v_Oferta_handlowa> searchOfferNo = db.v_Oferta_handlowa.Where(a => a.Numer_oferty == selectedNoint).ToList();
                if (searchOfferNo.Count() > 0)
                {
                    this.dgvOffers.DataSource = searchOfferNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer oferty: {tbOfferNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru oferty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPracownik.Text) || String.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedPracownikInt = int.Parse(cbPracownik.SelectedValue.ToString());
                int selectedOfferStatusInt = int.Parse(cbStatus.SelectedValue.ToString());
                Oferta_handlowa newoferta_handlowa = new Oferta_handlowa();
                newoferta_handlowa.Termin_realizacja = DoneDate.Value.Date;
                newoferta_handlowa.Pracownik = this.db.Pracownik.Single(a => a.ID_pracownik == selectedPracownikInt);
                newoferta_handlowa.Status_oferta = this.db.Status_oferta.Single(a => a.ID_status_oferta == selectedOfferStatusInt);
                this.db.Oferta_handlowa.Add(newoferta_handlowa);
                this.db.SaveChanges();
                MessageBox.Show("Skonstruowano ofertę handlową, dodaj produkty do oferty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOfferDetailsBeforeAgain = this.db.Oferta_handlowa_szczegol.Count();
                MessageBox.Show("Dodano ofertę!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcesHurtOfertaHandlowaDetails procesHurtOfertaHandlowaDetails = new ProcesHurtOfertaHandlowaDetails(db, newoferta_handlowa);
                procesHurtOfertaHandlowaDetails.ShowDialog();
                int counterOfferDetailsAfterAgain = this.db.Oferta_handlowa_szczegol.Count();
                if (counterOfferDetailsAfterAgain > counterOfferDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano ofertę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły oferty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvOffers.CurrentRow.Cells[0].Value.ToString());
            Oferta_handlowa selectedOrder = this.db.Oferta_handlowa.Single(a => a.ID_oferta_handlowa == selectedOrderDetails);
            ProcesHurtOfertaHandlowaDetails procesHurtOfertaHandlowaDetails = new ProcesHurtOfertaHandlowaDetails(db, selectedOrder);
            procesHurtOfertaHandlowaDetails.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvOffers.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć ofertę?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Oferta_handlowa selectedOferta = this.db.Oferta_handlowa.Single(a => a.ID_oferta_handlowa == salesDetailNo);
                    this.db.Oferta_handlowa.Remove(selectedOferta);
                    List<Oferta_handlowa_szczegol> selectOfferdetails = this.db.Oferta_handlowa_szczegol.Where(a => a.ID_oferta_handlowa == salesDetailNo).ToList();
                    this.db.Oferta_handlowa_szczegol.RemoveRange(selectOfferdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć oferty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProcesHurtUmowaSprzedaz procesHurtUmowaSprzedaz = new ProcesHurtUmowaSprzedaz(db);
            procesHurtUmowaSprzedaz.ShowDialog();
        }

        private void dgvOffers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbPracownik.Text = this.dgvOffers.CurrentRow.Cells[2].Value.ToString();
            cbStatus.Text = this.dgvOffers.CurrentRow.Cells[4].Value.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPracownik.Text) || String.IsNullOrEmpty(cbStatus.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedStustusInt = int.Parse(cbStatus.SelectedValue.ToString());
                int selectedPracownikInt = int.Parse(cbPracownik.SelectedValue.ToString());
                int currentID = int.Parse(dgvOffers.CurrentRow.Cells[0].Value.ToString());
                int newStatusID = int.Parse(cbStatus.SelectedValue.ToString());
                int newPracownikID = int.Parse(cbPracownik.SelectedValue.ToString());
                Oferta_handlowa result = db.Oferta_handlowa.SingleOrDefault(b => b.ID_oferta_handlowa == currentID);
                if (result != null)
                {
                    result.ID_status_oferta = newStatusID;
                    result.ID_pracownik = newPracownikID;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano status oferty.");
                showData();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProcesHurtZamowienie procesHurtZamowienie = new ProcesHurtZamowienie(db);
            procesHurtZamowienie.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ProcesHurtSprzedaz procesHurtSprzedaz = new ProcesHurtSprzedaz(db);
            procesHurtSprzedaz.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient_form klient_Form = new Klient_form(db);
            klient_Form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MagazynForm magazynForm = new MagazynForm(db);
            magazynForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewSalesDETAL newSalesDETAL = new NewSalesDETAL(db);
            newSalesDETAL.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KadryForm kadryForm = new KadryForm(db);
            kadryForm.ShowDialog();
            this.Close();
        }
    }
}
