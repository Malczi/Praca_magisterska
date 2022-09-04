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
    public partial class ReklamacjaDetal : Form
    {
        MGREntities db;
        public ReklamacjaDetal(MGREntities db)
        {
            InitializeComponent();
            showData();
            cbWorkerData();
            this.db = db;
        }

        private void cbWorkerData()
        {
            cbWorkerSurname.DataSource = this.db.v_Pracownik_stanowisko.Where(a => a.Stanowisko == "Sprzedawca" || a.Stanowisko == "Handlowiec").ToList();
            cbWorkerSurname.ValueMember = "ID_pracownik";
            cbWorkerSurname.DisplayMember = "Nazwisko";

        }
        private void showSalesData()
        {
            this.db = new MGREntities();
            this.dgvSales.DataSource = this.db.v_New_detal_sales.OrderBy(a => a.ID).ToList();
            dgvSales.Columns[1].Visible = false;
            dgvSales.Columns[2].Visible = false;
            dgvSales.Columns[3].Visible = false;
            dgvSales.Columns[0].HeaderText = "Data sprzedaży";
            dgvSales.Columns[4].HeaderText = "Numer sprzedaży";
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showComplaintData()
        {
            this.db = new MGREntities();
            this.dgvComplaint.DataSource = this.db.v_Reklamacja_detal.OrderBy(a => a.Numer_reklamacji).ToList();
            this.dgvComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showData()
        {
            showComplaintData();
            showSalesData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbSalesNumber.Text = this.dgvSales.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void searchNumber()
        {
            try
            {
                int selecedOrderIDInt = int.Parse(tbSalesNumber.Text);
                List<v_New_detal_sales> searchOrderNo = db.v_New_detal_sales.Where(a => a.ID == selecedOrderIDInt).ToList();
                if (searchOrderNo.Count() > 0)
                {
                    this.dgvSales.DataSource = searchOrderNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbSalesNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru zprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbSalesNumber.Clear();
        }
        private void msgCleanShowData(string searchKlient)
        {
            messageBox(searchKlient);
            cleanTextBox();
            showComplaintData();
        }
        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showComplaintData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbSalesNumber.Text.Length > 0)
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

        private void AddToList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbComplaintText.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedWorkerINT = int.Parse(cbWorkerSurname.SelectedValue.ToString());
                Reklamacja_detal newReklamacjaDetal = new Reklamacja_detal();
                newReklamacjaDetal.ID_pracownik = selectedWorkerINT;
                newReklamacjaDetal.ID_sprzedaz_detal = int.Parse(cbSalesNumber.Text);
                newReklamacjaDetal.Data_reklamacja = dtpDateComplaint.Value.Date;
                newReklamacjaDetal.Opis_reklamacja = tbComplaintText.Text;
                this.db.Reklamacja_detal.Add(newReklamacjaDetal);
                this.db.SaveChanges();
                MessageBox.Show("Skonstruowano nową reklamację!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOfferDetailsBeforeAgain = this.db.Szczegol_reklamacja_detal.Count();
                MessageBox.Show("Dodaj szczegóły reklamacji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReklamacjaDetalDetails reklamacjaDetalDetails = new ReklamacjaDetalDetails(db, newReklamacjaDetal);
                reklamacjaDetalDetails.ShowDialog();
                int counterOfferDetailsAfterAgain = this.db.Szczegol_reklamacja_detal.Count();
                if (counterOfferDetailsAfterAgain > counterOfferDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano reklamację", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły reklamacji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvComplaint.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć reklamację?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Reklamacja_detal selectedOferta = this.db.Reklamacja_detal.Single(a => a.ID_reklamacja_detal == salesDetailNo);
                    this.db.Reklamacja_detal.Remove(selectedOferta);
                    List<Szczegol_reklamacja_detal> selectOfferdetails = this.db.Szczegol_reklamacja_detal.Where(a => a.ID_reklamacja_detal == salesDetailNo).ToList();
                    this.db.Szczegol_reklamacja_detal.RemoveRange(selectOfferdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć reklmacji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvComplaint.CurrentRow.Cells[0].Value.ToString());
            Reklamacja_detal selectedOrder = this.db.Reklamacja_detal.Single(a => a.ID_reklamacja_detal == selectedOrderDetails);
            ReklamacjaDetalDetails reklamacjaDetalDetails = new ReklamacjaDetalDetails(db, selectedOrder);
            reklamacjaDetalDetails.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
