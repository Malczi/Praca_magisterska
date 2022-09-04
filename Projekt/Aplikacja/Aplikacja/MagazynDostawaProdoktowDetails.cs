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
    public partial class MagazynDostawaProdoktowDetails : Form
    {
        MGREntities db; Dostawa NewDETAL;
        public MagazynDostawaProdoktowDetails(MGREntities db, Dostawa NewDETAL)
        {
            InitializeComponent();
            this.db = db;
            this.NewDETAL = NewDETAL;
            showData();
        }
        private void showData()
        {
            this.db = new MGREntities();
            dgvPrediction.DataSource = db.v_Popyt_prediction.ToList();
            dgvPrediction.Columns[0].Visible = false;
            dgvPrediction.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvPrediction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            List<v_Dostawa_szczegol> selectedDeliveryDetails = this.db.v_Dostawa_szczegol.Where(b => b.Nr_dostawy == NewDETAL.ID_dostawa).ToList();
            dgvDeliveryDetails.DataSource = selectedDeliveryDetails;
            dgvDeliveryDetails.Columns[0].Visible = false;
            dgvDeliveryDetails.Columns[1].Visible = false;
            this.dgvDeliveryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrediction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            tbProduct.Text = this.dgvPrediction.CurrentRow.Cells[1].Value.ToString();
            tbAmount.Text = this.dgvPrediction.CurrentRow.Cells[3].Value.ToString();
        }
                
            

        private void button4_Click(object sender, EventArgs e)
        {
            Produkt selectedProduct = this.db.Produkt.SingleOrDefault(a => a.Nazwa == tbProduct.Text);

            if (selectedProduct != null)
            {
                Dostawa_szczegol dostawa_Szczegol = new Dostawa_szczegol();
                dostawa_Szczegol.ID_produkt = selectedProduct.ID_produkt;
                dostawa_Szczegol.Ilosc = int.Parse(tbAmount.Text);
                dostawa_Szczegol.Cena_szt = decimal.Parse(tbPrice.Text);
                dostawa_Szczegol.ID_dostawa = this.NewDETAL.ID_dostawa;
                this.db.Dostawa_szczegol.Add(dostawa_Szczegol);
                this.db.SaveChanges();
                showData();
                MessageBox.Show("Dodano produkt do oferty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanTextBox();
            }
            else
            {
                MessageBox.Show("Wprowadź dane nowego klienta do systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbAmount.Clear();
            tbPrice.Clear();
            tbProduct.Clear();
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deliveryDetailNo = int.Parse(this.dgvDeliveryDetails.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć szczegół dostawy?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Dostawa_szczegol selectedDostawaa = this.db.Dostawa_szczegol.Single(a => a.ID_dostawa_szczegol == deliveryDetailNo);
                    this.db.Dostawa_szczegol.Remove(selectedDostawaa);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć dostawy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
