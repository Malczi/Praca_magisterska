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
    public partial class NewSalesDETAL : Form
    {
        MGREntities db;
        public NewSalesDETAL(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            cbPayFormData();
            cbDeliveryTypeData();
            showData();
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvDetalSales.DataSource = this.db.v_New_detal_sales.OrderBy(a => a.ID).ToList();
            this.dgvDetalSales.Columns[4].HeaderText = "Numer sprzedaży";
            dgvDetalSales.Columns[0].Visible = false;
            this.dgvDetalSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
            private void cbPayFormData()
        {
            cbPayForm.DataSource = this.db.Forma_platnosc.ToList();
            cbPayForm.ValueMember = "ID_forma_platnosc";
            cbPayForm.DisplayMember = "Nazwa";
        }

        private void cbDeliveryTypeData()
        {
            cbDeliveryType.DataSource = this.db.Typ_odbioru.ToList();
            cbDeliveryType.ValueMember = "ID_typ_odbioru";
            cbDeliveryType.DisplayMember = "Nazwa";
        }
        private void refreshData()
        {
            showData();
            cbDeliveryTypeData();
            cbPayFormData();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbPayForm.Text) || String.IsNullOrEmpty(cbDeliveryType.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedPayFormInt = int.Parse(cbPayForm.SelectedValue.ToString());
                int selectedDeliveryTypeInt = int.Parse(cbDeliveryType.SelectedValue.ToString());
                Sprzedaz_detal newsprzedaz_detal = new Sprzedaz_detal();
                newsprzedaz_detal.Data_sprzedazy = SaleDate.Value.Date;
                newsprzedaz_detal.Termin_zaplata = PayDate.Value.Date;
                newsprzedaz_detal.Forma_platnosc = this.db.Forma_platnosc.Single(a => a.ID_forma_platnosc == selectedPayFormInt);
                newsprzedaz_detal.Typ_odbioru = this.db.Typ_odbioru.Single(a => a.ID_typ_odbioru == selectedDeliveryTypeInt);
                this.db.Sprzedaz_detal.Add(newsprzedaz_detal);
                this.db.SaveChanges();
                MessageBox.Show("Rozpoczęto nową sprzedaż, dodaj produkty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                int counterOrderDetailsBeforeAgain = this.db.Sprzedaz_szczegol_detal.Count();
                MessageBox.Show("Dodano zamówienie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewSalesDETAL_Details newSalesDETAL_Details = new NewSalesDETAL_Details(db, newsprzedaz_detal);
                newSalesDETAL_Details.ShowDialog();
                int counterOrderDetailsAfterAgain = this.db.Sprzedaz_szczegol_detal.Count();
                if (counterOrderDetailsAfterAgain > counterOrderDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano sprzedaż detaliczną", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły zamówienia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void FormNewOrder_Activated(object sender, EventArgs e)
        {
            showData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvDetalSales.CurrentRow.Cells[4].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć sprzedaż?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Sprzedaz_detal selectSprzedazDETAL = this.db.Sprzedaz_detal.Single(a => a.ID_sprzedaz_detal == salesDetailNo);
                    this.db.Sprzedaz_detal.Remove(selectSprzedazDETAL);
                    List<Sprzedaz_szczegol_detal> selectSprzedazDETALdetails = this.db.Sprzedaz_szczegol_detal.Where(a => a.ID_sprzedaz_detal == salesDetailNo).ToList();
                    this.db.Sprzedaz_szczegol_detal.RemoveRange(selectSprzedazDETALdetails);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvDetalSales.CurrentRow.Cells[4].Value.ToString());
            Sprzedaz_detal selectedOrder = this.db.Sprzedaz_detal.Single(a => a.ID_sprzedaz_detal == selectedOrderDetails);
            NewSalesDETAL_Details newSalesDETAL_Details = new NewSalesDETAL_Details(db, selectedOrder);
            newSalesDETAL_Details.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbSalesNumber.Text.Length > 0)
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
                int selectedIDint = int.Parse(tbSalesNumber.Text);
                List<v_New_detal_sales> searchSalesNo = db.v_New_detal_sales.Where(a => a.ID == selectedIDint).ToList();
                if (searchSalesNo.Count() > 0)
                {
                    this.dgvDetalSales.DataSource = searchSalesNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbSalesNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showData();
        }

        private void cleanTextBox()
        {
            tbSalesNumber.Clear();
        }

        private void msgCleanShowData(string searchSalesNo)
        {
            messageBox(searchSalesNo);
            cleanTextBox();
            showData();
        }

        private void messageBox(string searchSalesNo)
        {
            MessageBox.Show($"{searchSalesNo} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaleHurt_Click(object sender, EventArgs e)
        {
            SalesHURTform salesHURTform = new SalesHURTform(db);
            salesHURTform.ShowDialog();
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

        private void btnSaleDetal_Click(object sender, EventArgs e)
        {
            SalesDETALform salesDETALform = new SalesDETALform(db);
            salesDETALform.ShowDialog();
            this.Close();
        }

        private void btnMaszOgr_Click(object sender, EventArgs e)
        {
            ProcesHurtOfertaHandlowa procesHurtOfertaHandlowa = new ProcesHurtOfertaHandlowa(db);
            procesHurtOfertaHandlowa.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
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
