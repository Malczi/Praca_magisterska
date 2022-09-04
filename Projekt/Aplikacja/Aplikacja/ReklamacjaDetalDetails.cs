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
    public partial class ReklamacjaDetalDetails : Form
    {
        MGREntities db; Reklamacja_detal NewDETAL;
        public ReklamacjaDetalDetails(MGREntities db, Reklamacja_detal NewDETAL)
        {
            InitializeComponent();
            this.NewDETAL = NewDETAL;
            this.db = db;
            showData();
            cbComplaintTypeData();
        }

        private void cbComplaintTypeData()
        {
            cbComplaintType.DataSource = this.db.Typ_reklamacja.ToList();
            cbComplaintType.ValueMember = "ID_typ_reklamacja";
            cbComplaintType.DisplayMember = "Nazwa";
        }
        private void showData() 
        {
            this.db = new MGREntities();
            List<v_Reklamacja_detal_szczegol> selectedSale = this.db.v_Reklamacja_detal_szczegol.Where(a => a.Numer_reklamacji == NewDETAL.ID_reklamacja_detal).ToList();
            dgvComplaintDetails.DataSource = selectedSale;
            this.dgvComplaintDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db = new MGREntities();
            List<v_New_detal_sales_details> selectedOrderDetails = this.db.v_New_detal_sales_details.Where(b => b.Nr_sprzedazy == NewDETAL.ID_sprzedaz_detal).ToList();
            dgvSalesDetails.DataSource = selectedOrderDetails;
            dgvSalesDetails.Columns[0].Visible = false;
            dgvSalesDetails.Columns[4].Visible = false;
            dgvSalesDetails.Columns[6].Visible = false;
            this.dgvSalesDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSalesDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbProdukt.Text = this.dgvSalesDetails.CurrentRow.Cells[1].Value.ToString();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            Produkt selectedProduct = this.db.Produkt.SingleOrDefault(a => a.Nazwa == cbProdukt.Text);

            if (selectedProduct != null)
            {

                    int SelectedTypINT = int.Parse(cbComplaintType.SelectedValue.ToString());
                    Szczegol_reklamacja_detal szczegol_Reklamacja_Detal = new Szczegol_reklamacja_detal();
                    szczegol_Reklamacja_Detal.ID_produkt = selectedProduct.ID_produkt;
                    szczegol_Reklamacja_Detal.ID_typ_reklamacja = SelectedTypINT;
                    szczegol_Reklamacja_Detal.Ilosc = int.Parse(tbAmount.Text);
                    szczegol_Reklamacja_Detal.Uwagi = tbUwagi.Text;
                    szczegol_Reklamacja_Detal.Utylizacja = chbUtylizacja.Checked;
                    szczegol_Reklamacja_Detal.ID_reklamacja_detal = this.NewDETAL.ID_reklamacja_detal;
                    this.db.Szczegol_reklamacja_detal.Add(szczegol_Reklamacja_Detal);
                    this.db.SaveChanges();
                    showData();
                    MessageBox.Show("Dodano produkt do reklamacji!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanTextBox();

            }
            else
            {
                MessageBox.Show("Wprowadź brakujące dane systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbAmount.Clear();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            this.db = new MGREntities();
            List<v_Reklamacja_detal_szczegol> selectedSale = this.db.v_Reklamacja_detal_szczegol.Where(a => a.Numer_reklamacji == NewDETAL.ID_sprzedaz_detal).ToList();
            dgvComplaintDetails.DataSource = selectedSale;
            this.dgvComplaintDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<v_New_detal_sales_details> searchOrderNo = db.v_New_detal_sales_details.Where(a => a.Produkt == tbProductNo.Text).ToList();
                if (searchOrderNo.Count() > 0)
                {
                    this.dgvSalesDetails.DataSource = searchOrderNo;
                    tbProductNo.Clear();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbProductNo.Text}");
                }
            }
            catch (Exception)
            {
                tbProductNo.Clear(); 
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void msgCleanShowData(string searchKlient)
        {
            messageBox(searchKlient);
            tbProductNo.Clear();
            this.db = new MGREntities();
            List<v_Reklamacja_detal_szczegol> selectedSale = this.db.v_Reklamacja_detal_szczegol.Where(a => a.Numer_reklamacji == NewDETAL.ID_sprzedaz_detal).ToList();
            dgvComplaintDetails.DataSource = selectedSale;
            this.dgvComplaintDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvComplaintDetails.CurrentRow.Cells[1].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć reklamację?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Szczegol_reklamacja_detal selectedOferta = this.db.Szczegol_reklamacja_detal.Single(a => a.ID_szczegol_reklamacja_detal == salesDetailNo);
                    this.db.Szczegol_reklamacja_detal.Remove(selectedOferta);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć reklamacji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
