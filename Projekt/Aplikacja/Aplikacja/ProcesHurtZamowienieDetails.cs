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
    public partial class ProcesHurtZamowienieDetails : Form
    {
        MGREntities db; Zamowienie NewDETAL;
        public ProcesHurtZamowienieDetails(MGREntities db, Zamowienie NewDETAL)
        {
            InitializeComponent();
            this.db = db;
            this.NewDETAL = NewDETAL;
            showData();
        }

        private void showData()
        {
            this.db = new MGREntities();
            List<v_Zamowienie_szczegol> selectedOrder = this.db.v_Zamowienie_szczegol.Where(a => a.Numer_zamówienia == NewDETAL.ID_zamowienie).ToList();
            dgvOrderDetails.DataSource = selectedOrder;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            List<v_Oferta_handlowa_szczegol> selectedOfferDetails = this.db.v_Oferta_handlowa_szczegol.Where(b => b.Numer_oferty == NewDETAL.ID_oferta_handlowa).ToList();
            dgvOfferDetails.DataSource = selectedOfferDetails;
            dgvOfferDetails.Columns[0].Visible = false;
            dgvOfferDetails.Columns[3].Visible = false;
            dgvOfferDetails.Columns[4].Visible = false;
            this.dgvOfferDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvOfferDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbProduct.Text = this.dgvOfferDetails.CurrentRow.Cells[1].Value.ToString();
            tbAmount.Text = this.dgvOfferDetails.CurrentRow.Cells[2].Value.ToString();
        }
        private void cleanTextBox()
        {
            tbAmount.Clear();
            tbProduct.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            Produkt selectedProduct = this.db.Produkt.SingleOrDefault(a => a.Nazwa == tbProduct.Text);

            if (selectedProduct != null)
            {
                Zamowienie_szczegol zamowienie_Szczegol = new Zamowienie_szczegol();
                zamowienie_Szczegol.ID_produkt = selectedProduct.ID_produkt;
                zamowienie_Szczegol.Ilosc = int.Parse(tbAmount.Text);
                zamowienie_Szczegol.ID_zamowienie = this.NewDETAL.ID_zamowienie;
                this.db.Zamowienie_szczegol.Add(zamowienie_Szczegol);
                this.db.SaveChanges();
                showData();
                MessageBox.Show("Dodano produkt do zamówienia!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox();
            }
            else
            {
                MessageBox.Show("Wprowadź dane systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            int salesDetailNo = int.Parse(this.dgvOrderDetails.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć szczegół zamówienia?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Zamowienie_szczegol selectedOferta = this.db.Zamowienie_szczegol.Single(a => a.ID_zamowienie_szczegol == salesDetailNo);
                    this.db.Zamowienie_szczegol.Remove(selectedOferta);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć zamówienia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
