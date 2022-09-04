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
    public partial class ProcesHurtOfertaHandlowaDetails : Form
    {
        MGREntities db; Oferta_handlowa NewDETAL;
        public ProcesHurtOfertaHandlowaDetails(MGREntities db, Oferta_handlowa NewDETAL)
        {
            InitializeComponent();
            this.db = db;
            this.NewDETAL = NewDETAL;
            cbProductsData();
            showData();
            cbPodatekData();
        }
        private void showData()
        {
            this.db = new MGREntities();
            List<v_Oferta_handlowa_szczegol> selectedOffer = this.db.v_Oferta_handlowa_szczegol.Where(a => a.Numer_oferty == NewDETAL.ID_oferta_handlowa).ToList();
            dgvOfferDetails.DataSource = selectedOffer;
            this.dgvOfferDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            this.dgvProducts.DataSource = this.db.v_Products_oferta_handlowa.OrderBy(a => a.Nazwa_produktu).ToList();
            dgvProducts.Columns[0].Visible = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
        private void clearTextBoxAmount()
        {
            tbValueProd.Clear();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            int selectedProduct = int.Parse(cbProducts.SelectedValue.ToString());
            int selectedPodatek = int.Parse(cbPodatek.SelectedValue.ToString());
            List<Oferta_handlowa_szczegol> searchOrder = this.db.Oferta_handlowa_szczegol.Where(a => a.ID_produkt == selectedProduct && a.ID_oferta_handlowa == NewDETAL.ID_oferta_handlowa).ToList();
            if (searchOrder.Count > 0)
            {
                MessageBox.Show("Ten produkt został już dodany!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxAmount();
            }
            else
            {
                try
                {
                    Oferta_handlowa_szczegol oferta_Handlowa_Szczegol = new Oferta_handlowa_szczegol();
                    oferta_Handlowa_Szczegol.ID_oferta_handlowa = this.NewDETAL.ID_oferta_handlowa;
                    oferta_Handlowa_Szczegol.ID_produkt = selectedProduct;
                    oferta_Handlowa_Szczegol.Cena_netto_za_jednostke = decimal.Parse(tbPrice.Text);
                    oferta_Handlowa_Szczegol.ID_podatek = selectedPodatek;
                    oferta_Handlowa_Szczegol.Ilosc = int.Parse(tbValueProd.Text);
                    this.db.Oferta_handlowa_szczegol.Add(oferta_Handlowa_Szczegol);
                    this.db.SaveChanges();
                    showData();
                    MessageBox.Show("Dodano produkt do oferty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBoxAmount();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wystąpił błąd!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvOfferDetails.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć szczegół oferty?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Oferta_handlowa_szczegol selectedOferta = this.db.Oferta_handlowa_szczegol.Single(a => a.ID_oferta_handlowa_szczegol == salesDetailNo);
                    this.db.Oferta_handlowa_szczegol.Remove(selectedOferta);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć oferty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.db = new MGREntities();
            this.dgvProducts.DataSource = this.db.v_Products_oferta_handlowa.OrderBy(a => a.Nazwa_produktu).ToList();
            dgvProducts.Columns[0].Visible = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
