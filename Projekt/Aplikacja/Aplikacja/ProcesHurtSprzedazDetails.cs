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
    public partial class ProcesHurtSprzedazDetails : Form
    {
        MGREntities db; Sprzedaz_hurt NewDETAL;
        public ProcesHurtSprzedazDetails(MGREntities db, Sprzedaz_hurt NewDETAL)
        {
            InitializeComponent();
            this.db = db;
            this.NewDETAL = NewDETAL;
            showData();
            cbJednostkaData();
        }
        private void showData()
        {
            this.db = new MGREntities();
            List<v_Sprzedaz_szczegol_hurt> selectedSale = this.db.v_Sprzedaz_szczegol_hurt.Where(a => a.Numer_sprzedaży == NewDETAL.ID_sprzedaz_hurt).ToList();
            dgvSaleDetails.DataSource = selectedSale;
            dgvSaleDetails.Columns[0].Visible = false;
            dgvSaleDetails.Columns[1].Visible = false;
            this.dgvSaleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            List<v_Zamowienie_szczegol> selectedOrderDetails = this.db.v_Zamowienie_szczegol.Where(b => b.Numer_zamówienia == NewDETAL.ID_zamowienie).ToList();
            dgvOrderDetails.DataSource = selectedOrderDetails;
            dgvOrderDetails.Columns[0].Visible = false;
            dgvOrderDetails.Columns[1].Visible = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cbJednostkaData()
        {
            cbJednostka.DataSource = this.db.Jednostka.ToList();
            cbJednostka.ValueMember = "ID_jednostka";
            cbJednostka.DisplayMember = "Nazwa";
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbProduct.Text = this.dgvOrderDetails.CurrentRow.Cells[2].Value.ToString();
            tbAmount.Text = this.dgvOrderDetails.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Produkt selectedProduct = this.db.Produkt.SingleOrDefault(a => a.Nazwa == tbProduct.Text);

            if (selectedProduct != null)
            {
                int SelectedJednostkaINT = int.Parse(cbJednostka.SelectedValue.ToString());
                Sprzedaz_szczegol_hurt sprzedaz_Szczegol_Hurt = new Sprzedaz_szczegol_hurt();
                sprzedaz_Szczegol_Hurt.ID_produkt = selectedProduct.ID_produkt;
                sprzedaz_Szczegol_Hurt.Ilosc = int.Parse(tbAmount.Text);
                sprzedaz_Szczegol_Hurt.ID_jednostka = SelectedJednostkaINT;
                sprzedaz_Szczegol_Hurt.ID_sprzedaz_hurt = this.NewDETAL.ID_sprzedaz_hurt;
                this.db.Sprzedaz_szczegol_hurt.Add(sprzedaz_Szczegol_Hurt);
                this.db.SaveChanges();
                showData();
                MessageBox.Show("Dodano produkt do sprzedaży!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox();
            }
            else
            {
                MessageBox.Show("Wprowadź dane systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbAmount.Clear();
            tbProduct.Clear();
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
            int salesDetailNo = int.Parse(this.dgvSaleDetails.CurrentRow.Cells[1].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć szczegół sprzedaży?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sprzedaz_szczegol_hurt selectedOferta = this.db.Sprzedaz_szczegol_hurt.Single(a => a.ID_sprzedaz_szczegol_hurt == salesDetailNo);
                    this.db.Sprzedaz_szczegol_hurt.Remove(selectedOferta);
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
