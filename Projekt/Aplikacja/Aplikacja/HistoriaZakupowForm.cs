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
    public partial class HistoriaZakupowForm : Form
    {
        MGREntities db;
        public HistoriaZakupowForm(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
        }
        private void messageBox(string searchItem)
        {
            MessageBox.Show($"{searchItem} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void msgCleanShowData(string searchItem)
        {
            messageBox(searchItem);
            cleanTextBox();
            showData();
        }

        private void showData()
        {
        this.db = new MGREntities();
        this.dgvAllBuyedProds.DataSource = db.v_Sprzedaz_hurt_klient.ToList();
        this.dgvAllBuyedProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvAllBuyedProds.Columns[4].Visible = false;
        this.dgvAllBuyedProds.Columns[0].HeaderText = "Data zakupu";
        this.dgvAllBuyedProds.Columns[1].HeaderText = "Nazwisko klienta";
        this.dgvAllBuyedProds.Columns[2].HeaderText = "Imię kliena";
        this.dgvAllBuyedProds.Columns[3].HeaderText = "Status klienta";
        }

        private void cleanTextBox()
        {
            tbNumber.Clear();
            tbName.Clear();
            tbSurname.Clear();
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

        private void dgvAllBuyedProds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowINT = int.Parse(dgvAllBuyedProds.CurrentRow.Cells[4].Value.ToString());
            this.db = new MGREntities();
            this.dgvSalesDetails.DataSource = db.v_Sprzedaz_hurt_klient_detalis.Where(a => a.Nr_sprzedazy == selectedRowINT).ToList();
            this.dgvSalesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesDetails.Columns[0].Visible = false;
            this.dgvSalesDetails.Columns[4].Visible = false;
            this.dgvSalesDetails.Columns[2].HeaderText = "Numer produktu";
            this.dgvSalesDetails.Columns[5].HeaderText = "Cena (za szt.)";
            this.dgvSalesDetails.Columns[6].HeaderText = "Kwaota do zapłaty";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbNumber.Text.Length > 0)
                choose = "Number";
            if (tbName.Text.Length > 0)
                choose = "Name";
            if (tbSurname.Text.Length > 0)
                choose = "Surname";
            switch (choose)
            {
                case "Number":
                    searchNumber();
                    break;
                case "Name":
                    searchName();
                    break;
                case "Surname":
                    searchSurname();
                    break;
                default:
                    wrongData();
                    break;
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void searchNumber()
        {
            try
            {
                int noSalesINT = int.Parse(tbNumber.Text);
                List<v_Sprzedaz_hurt_klient> searchSalestNo = db.v_Sprzedaz_hurt_klient.Where(a => a.ID == noSalesINT).ToList();
                if (searchSalestNo.Count() > 0)
                {
                    this.dgvAllBuyedProds.DataSource = searchSalestNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr sprzedazy: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchName()
        {
            try
            {
                string noName = tbName.Text;
                List<v_Sprzedaz_hurt_klient> searchSalestName = db.v_Sprzedaz_hurt_klient.Where(a => a.Imię_klienta == noName).ToList();
                if (searchSalestName.Count() > 0)
                {
                    this.dgvAllBuyedProds.DataSource = searchSalestName;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwane imię: {tbName.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś poprawne imię!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void searchSurname()
            {
                try
                {
                    string noSurname = tbSurname.Text;
                    List<v_Sprzedaz_hurt_klient> searchSalestSurname = db.v_Sprzedaz_hurt_klient.Where(a => a.Nazwisko_klienta == noSurname).ToList();
                    if (searchSalestSurname.Count() > 0)
                    {
                        this.dgvAllBuyedProds.DataSource = searchSalestSurname;
                        cleanTextBox();
                    }
                    else
                    {
                        msgCleanShowData($"Wyszukiwane nazwisko: {tbSurname.Text}");
                    }
                }
                catch (Exception)
                {
                    cleanTextBox();
                    MessageBox.Show("Sprawdź czy nie wprowadziłeś poprawne nazwisko!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnGarden_Click(object sender, EventArgs e)
        {
            KlientEdit_FORM klientEdit_FORM = new KlientEdit_FORM(db);
            klientEdit_FORM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MagazynForm magazynForm = new MagazynForm(db);
            magazynForm.ShowDialog();
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
