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
    public partial class All_products_form : Form
    {
        MGREntities db;
        public All_products_form(MGREntities db)
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
            this.dgvAll_prods.DataSource = db.v_Products.ToList();
            this.dgvAll_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            showData();
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


        private void btnBudowa_Click(object sender, EventArgs e)
        {
            Bulid_products_form bulid_Products_Form = new Bulid_products_form(db);
            bulid_Products_Form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Garden_products_form garden_Products_Form = new Garden_products_form(db);
            garden_Products_Form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Technic_products_form technic_Products_Form = new Technic_products_form(db);
            technic_Products_Form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flat_products_form flat_Products_Form = new Flat_products_form(db);
            flat_Products_Form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitchen_products_form kitchen_Products_Form = new Kitchen_products_form(db);
            kitchen_Products_Form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bath_products_form bath_Products_Form = new Bath_products_form(db);
            bath_Products_Form.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_products_form add_Products_Form = new Add_products_form(db);
            add_Products_Form.ShowDialog();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbNazwa.Text.Length > 0)
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
                int noProductInt = int.Parse(tbNazwa.Text);
                List<v_Products> searchProductNo = db.v_Products.Where(a => a.Numer_produktu == noProductInt).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgvAll_prods.DataSource = searchProductNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany nr produktu: {tbNazwa.Text}");
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

        private void cleanTextBox()
        {
            tbNazwa.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedRowINT = int.Parse(this.dgvAll_prods.CurrentRow.Cells[0].Value.ToString());
            Produkt selectedProdukt = db.Produkt.Single(a => a.ID_produkt == selectedRowINT);
            if (selectedRowINT != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć klienta: {selectedProdukt.Nazwa} {selectedProdukt.Nr_produkt}?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.Produkt.Remove(selectedProdukt);

                        this.db.SaveChanges();
                        MessageBox.Show("Produkt został usunięty z bazy danych!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Produkt widnieje w historii zamówień. Nie można usunąć go usuąć", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void FormSalesDepartmentClient_Activated(object sender, EventArgs e)
        {
            showData();
        }

    }
}

