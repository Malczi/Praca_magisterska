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
    public partial class ProcesHurtSprzedaz : Form
    {
        MGREntities db;
        public ProcesHurtSprzedaz(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            cbCollectFormData();
            cbPayFormData();
            showData();
        }
        private void cbCollectFormData()
        {
            cbCollectForm.DataSource = this.db.Typ_odbioru.ToList();
            cbCollectForm.ValueMember = "ID_typ_odbioru";
            cbCollectForm.DisplayMember = "Nazwa";
        }

        private void cbPayFormData()
        {
            cbPayForm.DataSource = this.db.Forma_platnosc.ToList();
            cbPayForm.ValueMember = "ID_forma_platnosc";
            cbPayForm.DisplayMember = "Nazwa";
        }

        private void showOrdersData()
        {
            this.db = new MGREntities();
            this.dgvOrders.DataSource = this.db.v_Zamowienie.OrderBy(a => a.Numer_zamowienia).ToList();
            dgvOrders.Columns[1].Visible = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showSalesHurtData()
        {
            this.db = new MGREntities();
            this.dgvSales.DataSource = this.db.v_Sprzedaz_hurt.OrderBy(a => a.Numer_sprzedaży).ToList();
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showData()
        {
            showOrdersData();
            showSalesHurtData();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOrderNo.Text = this.dgvOrders.CurrentRow.Cells[0].Value.ToString();
        }
        private void searchNumber()
        {
            try
            {
                int selecedOrderIDInt = int.Parse(tbNumber.Text);
                List<v_Zamowienie> searchOrderNo = db.v_Zamowienie.Where(a => a.Numer_zamowienia == selecedOrderIDInt).ToList();
                if (searchOrderNo.Count() > 0)
                {
                    this.dgvOrders.DataSource = searchOrderNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer zamówienia: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            showOrdersData();
        }
        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showOrdersData();
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
            showOrdersData();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbOrderNo.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedCollectINT = int.Parse(cbCollectForm.SelectedValue.ToString());
                int selectedPayFormINT = int.Parse(cbPayForm.SelectedValue.ToString());
                int selectedOrderINT = int.Parse(tbOrderNo.Text);
                Sprzedaz_hurt newsprzedazHurt = new Sprzedaz_hurt();
                newsprzedazHurt.Data_sprzedazy = dtpDateSale.Value.Date;
                newsprzedazHurt.Termin_zaplata = dtpDatePay.Value.Date;
                newsprzedazHurt.ID_forma_platnosc = selectedPayFormINT;
                newsprzedazHurt.ID_Typ_odbioru = selectedCollectINT;
                newsprzedazHurt.ID_zamowienie = selectedOrderINT;
                this.db.Sprzedaz_hurt.Add(newsprzedazHurt);
                this.db.SaveChanges();
                MessageBox.Show("Skonstruowano nową sprzedaż!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOfferDetailsBeforeAgain = this.db.Zamowienie_szczegol.Count();
                MessageBox.Show("Dodaj szczegóły sprzedaży!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcesHurtSprzedazDetails procesHurtSprzedazDetails = new ProcesHurtSprzedazDetails(db, newsprzedazHurt);
                procesHurtSprzedazDetails.ShowDialog();
                int counterOfferDetailsAfterAgain = this.db.Sprzedaz_szczegol_hurt.Count();
                if (counterOfferDetailsAfterAgain > counterOfferDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano sprzedaż", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły sprzedaży", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvSales.CurrentRow.Cells[0].Value.ToString());
            Sprzedaz_hurt selectedOrder = this.db.Sprzedaz_hurt.Single(a => a.ID_sprzedaz_hurt == selectedOrderDetails);
            ProcesHurtSprzedazDetails procesHurtSprzedazDetails = new ProcesHurtSprzedazDetails(db, selectedOrder);
            procesHurtSprzedazDetails.ShowDialog();
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvSales.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć sprzedaż?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sprzedaz_hurt selectedOferta = this.db.Sprzedaz_hurt.Single(a => a.ID_sprzedaz_hurt == salesDetailNo);
                    this.db.Sprzedaz_hurt.Remove(selectedOferta);
                    List<Sprzedaz_szczegol_hurt> selectOfferdetails = this.db.Sprzedaz_szczegol_hurt.Where(a => a.ID_sprzedaz_hurt == salesDetailNo).ToList();
                    this.db.Sprzedaz_szczegol_hurt.RemoveRange(selectOfferdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
