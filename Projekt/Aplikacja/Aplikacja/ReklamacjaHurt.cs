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
    public partial class ReklamacjaHurt : Form
    {
        MGREntities db;
        public ReklamacjaHurt(MGREntities db)
        {
            InitializeComponent();
            showData();
            this.db = db;
            cbWorkerData();
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
            this.dgvSalesHurt.DataSource = this.db.v_Sprzedaz_hurt.OrderBy(a => a.Numer_sprzedaży).ToList();
            dgvSalesHurt.Columns[1].Visible = false;
            dgvSalesHurt.Columns[3].Visible = false;
            dgvSalesHurt.Columns[4].Visible = false;
            dgvSalesHurt.Columns[5].Visible = false;
            this.dgvSalesHurt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showComplaintData()
        {
            this.db = new MGREntities();
            this.dgvComplaintHurt.DataSource = this.db.v_Reklamacja_hurt.OrderBy(a => a.Numer_reklamacji).ToList();
            this.dgvComplaintHurt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showData()
        {
            showComplaintData();
            showSalesData();
        }

        private void searchNumber()
        {
            try
            {
                int selecedOrderIDInt = int.Parse(tbSalesNumber.Text);
                List<v_Sprzedaz_hurt> searchOrderNo = db.v_Sprzedaz_hurt.Where(a => a.Numer_sprzedaży == selecedOrderIDInt).ToList();
                if (searchOrderNo.Count() > 0)
                {
                    this.dgvSalesHurt.DataSource = searchOrderNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer zamówienia: {tbSalesNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Reklamacja_hurt newReklamacjaHurt = new Reklamacja_hurt();
                newReklamacjaHurt.ID_pracownik = selectedWorkerINT;
                newReklamacjaHurt.ID_sprzedaz_hurt = int.Parse(cbSalesNumber.Text);
                newReklamacjaHurt.Data_reklamacja = dtpDateComplaint.Value.Date;
                newReklamacjaHurt.Opis_reklamacja = tbComplaintText.Text;
                this.db.Reklamacja_hurt.Add(newReklamacjaHurt);
                this.db.SaveChanges();
                MessageBox.Show("Skonstruowano nową reklamację!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOfferDetailsBeforeAgain = this.db.Szczegol_reklamacja_hurt.Count();
                MessageBox.Show("Dodaj szczegóły reklamacji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReklamacjaHurtDetails reklamacjaHurtDetails = new ReklamacjaHurtDetails(db, newReklamacjaHurt);
                reklamacjaHurtDetails.ShowDialog();
                int counterOfferDetailsAfterAgain = this.db.Szczegol_reklamacja_hurt.Count();
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
            int salesDetailNo = int.Parse(this.dgvComplaintHurt.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć reklamację?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Reklamacja_hurt selectedOferta = this.db.Reklamacja_hurt.Single(a => a.ID_reklamacja_hurt == salesDetailNo);
                    this.db.Reklamacja_hurt.Remove(selectedOferta);
                    List<Szczegol_reklamacja_hurt> selectOfferdetails = this.db.Szczegol_reklamacja_hurt.Where(a => a.ID_reklamacja_hurt == salesDetailNo).ToList();
                    this.db.Szczegol_reklamacja_hurt.RemoveRange(selectOfferdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć reklamacji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvComplaintHurt.CurrentRow.Cells[0].Value.ToString());
            Reklamacja_hurt selectedOrder = this.db.Reklamacja_hurt.Single(a => a.ID_reklamacja_hurt == selectedOrderDetails);
            ReklamacjaHurtDetails reklamacjaHurtDetails = new ReklamacjaHurtDetails(db, selectedOrder);
            reklamacjaHurtDetails.ShowDialog();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            showSalesData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbSalesNumber.Text = this.dgvSalesHurt.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
