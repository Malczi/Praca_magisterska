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
    public partial class NewSalesDETAL_Details : Form
    {
        MGREntities db;
        Sprzedaz_detal NewDETAL;
        public NewSalesDETAL_Details(MGREntities db, Sprzedaz_detal NewDETAL)
        {
            InitializeComponent();
            this.db = db;
            this.NewDETAL = NewDETAL;
            cbProductsData();
            showData();
            cbPodatekData();
            cbJednostkaData();
            tbPriceData();
        }

        private void cbProductsData()
        {
            cbProducts.DataSource = this.db.Produkt.ToList();
            cbProducts.ValueMember = "ID_produkt";
            cbProducts.DisplayMember = "Nazwa";
        }

        private void cbPodatekData()
        {
            cbPodatek.DataSource = this.db.Podatek.ToList();
            cbPodatek.ValueMember = "ID_podatek";
            cbPodatek.DisplayMember = "Procent";
        }

        private void cbJednostkaData()
        {
            cbJednostka.DataSource = this.db.Jednostka.ToList();
            cbJednostka.ValueMember = "ID_jednostka";
            cbJednostka.DisplayMember = "Nazwa";
        }

        private void tbPriceData()
        {
            int selectedProdInt = int.Parse(cbProducts.SelectedValue.ToString());
            v_Products selectedRow = this.db.v_Products.Where(a => a.ID_produktu == selectedProdInt).First();
            tbPrice.Text = selectedRow.Cena_netto.ToString();
        }

        private void showData()
        {
            this.db = new MGREntities();
            List<v_New_detal_sales_details> selectedSale = this.db.v_New_detal_sales_details.Where(a => a.Nr_sprzedazy == NewDETAL.ID_sprzedaz_detal).ToList();
            dgvShopList.DataSource = selectedSale;
            this.dgvShopList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            this.dgvProducts.DataSource = this.db.v_Products_oferta_handlowa.OrderBy(a => a.Nazwa_produktu).ToList();
            dgvProducts.Columns[0].Visible = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void clearTextBoxAmount()
        {
            tbValueProd.Clear();
        }


        private void AddToList_Click_1(object sender, EventArgs e)
        
            {
            int selectedProduct = int.Parse(cbProducts.SelectedValue.ToString());
            int selectedJednostka = int.Parse(cbJednostka.SelectedValue.ToString());
            int selectedPodatek = int.Parse(cbPodatek.SelectedValue.ToString());
            List<Sprzedaz_szczegol_detal> searchOrder = this.db.Sprzedaz_szczegol_detal.Where(a => a.ID_produkt == selectedProduct && a.ID_sprzedaz_detal == NewDETAL.ID_sprzedaz_detal).ToList();
            if (searchOrder.Count > 0)
                {
                    MessageBox.Show("Ten produkt został już dodany!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearTextBoxAmount();
                }
                else
                {
                    try
                    {
                        Sprzedaz_szczegol_detal sprzedaz_Szczegol_Detal = new Sprzedaz_szczegol_detal();
                        sprzedaz_Szczegol_Detal.ID_sprzedaz_detal = this.NewDETAL.ID_sprzedaz_detal;
                        sprzedaz_Szczegol_Detal.ID_produkt = selectedProduct;
                        sprzedaz_Szczegol_Detal.ID_jednostka = selectedJednostka;
                        sprzedaz_Szczegol_Detal.Cena_netto_za_jednostke = decimal.Parse(tbPrice.Text);
                        sprzedaz_Szczegol_Detal.ID_podatek = selectedPodatek;
                        sprzedaz_Szczegol_Detal.Ilosc = int.Parse(tbValueProd.Text);
                        this.db.Sprzedaz_szczegol_detal.Add(sprzedaz_Szczegol_Detal);
                        this.db.SaveChanges();
                        showData();
                        MessageBox.Show("Dodano produkt do rachunku!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTextBoxAmount();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wystąpił błąd!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void dgvShopList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvShopList.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć produkt z rachunku?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sprzedaz_szczegol_detal selectSprzedazDetailsDETAL = this.db.Sprzedaz_szczegol_detal.Single(a => a.ID_sprzedaz_szczegol_detal == salesDetailNo);
                    this.db.Sprzedaz_szczegol_detal.Remove(selectSprzedazDetailsDETAL);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć produktu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.db.SaveChanges();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbProducts.Text = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = this.dgvProducts.CurrentRow.Cells[3].Value.ToString();
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
        private void searchNumber()
        {
            try
            {
                int noProductInt = int.Parse(tbNumber.Text);
                List<v_Products_oferta_handlowa> searchProductNo = db.v_Products_oferta_handlowa.Where(a => a.Numer_produktu == noProductInt).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgvProducts.DataSource = searchProductNo;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.db = new MGREntities();
            this.dgvProducts.DataSource = this.db.v_Products_oferta_handlowa.OrderBy(a => a.Nazwa_produktu).ToList();
            dgvProducts.Columns[0].Visible = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvShopList.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć szczegół sprzedaży?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sprzedaz_szczegol_detal selectedOferta = this.db.Sprzedaz_szczegol_detal.Single(a => a.ID_sprzedaz_szczegol_detal == salesDetailNo);
                    this.db.Sprzedaz_szczegol_detal.Remove(selectedOferta);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć szczegółu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
