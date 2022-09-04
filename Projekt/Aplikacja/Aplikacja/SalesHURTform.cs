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
    public partial class SalesHURTform : Form
    {
        MGREntities db;
        public SalesHURTform(MGREntities db)
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
            dgv_SalesHurt.DataSource = db.v_All_hurt_sold_products.ToList();
            dgv_SalesHurt.Columns[0].Visible = false;
            dgv_SalesHurt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgv_SalesHurt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SalesHurt.Columns[1].HeaderText = "Nazwa produktu";
            this.dgv_SalesHurt.Columns[2].HeaderText = "Numer produktu";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesDETALform salesDETALform = new SalesDETALform(db);
            salesDETALform.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            showData();
        }

        private void button7_Click(object sender, EventArgs e)
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
                List<v_All_hurt_sold_products> searchProductNo = db.v_All_hurt_sold_products.Where(a => a.Numer_produktu == NoProduct).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgv_SalesHurt.DataSource = searchProductNo;
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
