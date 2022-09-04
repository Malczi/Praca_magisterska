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
    public partial class MagazynForm : Form
    {
        MGREntities db;
        public MagazynForm(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }

        private void showData()
        {
           this.db = new MGREntities();
            dgvMagazyn.DataSource = db.v_All_avalaible_products.ToList();
            dgvMagazyn.Columns[0].Visible = false;
            dgvMagazyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvMagazyn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient_form klient_Form = new Klient_form(db);
            klient_Form.ShowDialog();
            this.Close();
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

        private void backToSales_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MagazynPlanowanyPopyt magazynPlanowanyPopyt = new MagazynPlanowanyPopyt(db);
            magazynPlanowanyPopyt.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
        private void searchNumber()
        {
            try
            {
                int noProductInt = int.Parse(tbNumber.Text);
                List<v_All_avalaible_products> searchProductNo = db.v_All_avalaible_products.Where(a => a.Numer_produktu == noProductInt).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgvMagazyn.DataSource = searchProductNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr produktu: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru produktu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void msgCleanShowData(string searchItem)
        {
            messageBox(searchItem);
            cleanTextBox();
            showData();
        }

        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void cleanTextBox()
        {
            tbNumber.Clear();
        }

        private void messageBox(string searchItem)
        {
            MessageBox.Show($"{searchItem} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            showData();
            cleanTextBox();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            MagazynDostawaProduktow magazynDostawaProduktow = new MagazynDostawaProduktow(db);
            magazynDostawaProduktow.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KadryForm kadryForm = new KadryForm(db);
            kadryForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chartMagazyny magazynStatystyki = new chartMagazyny(db);
            magazynStatystyki.ShowDialog();
        }
    }
    }

