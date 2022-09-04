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
    public partial class SalesDETALform : Form
    {
        MGREntities db;
        public SalesDETALform(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
        }

        private void cleanTextBox()
        {
            tbNumber.Clear();
        }

        private void showData()
        {
            dgvSales_Detal.DataSource = db.v_All_detal_sold_products.ToList();
            dgvSales_Detal.Columns[0].Visible = false;
            dgvSales_Detal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvSales_Detal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales_Detal.Columns[1].HeaderText = "Nazwa produktu";
            this.dgvSales_Detal.Columns[2].HeaderText = "Numer produktu";
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

        private void btnBuild_Click(object sender, EventArgs e)
        {
            SalesHURTform salesHURTform = new SalesHURTform(db);
            salesHURTform.ShowDialog();
            this.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            showData(); 
        }
        private void backToSales_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
            this.Close();
        }

        private void searchNumber()
        {
            try
            {
                int NoProduct = int.Parse(tbNumber.Text);
                List<v_All_detal_sold_products> searchProductNo = db.v_All_detal_sold_products.Where(a => a.Numer_produktu == NoProduct).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgvSales_Detal.DataSource = searchProductNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer telefonu: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru produktu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void messageBox(string searchProduct)
        {
            MessageBox.Show($"{searchProduct} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgCleanShowData(string searchProduct)
        {
            messageBox(searchProduct);
            cleanTextBox();
            showData();
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
