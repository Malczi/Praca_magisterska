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
    public partial class MagazynDostawaProduktow : Form
    {
        MGREntities db;
        public MagazynDostawaProduktow(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cbProducentData();
            cbPracownikData();
        }
        private void showPredictionData()
        {
            this.db = new MGREntities();
            dgvPrediction.DataSource = db.v_Popyt_prediction.ToList();
            dgvPrediction.Columns[0].Visible = false;
            dgvPrediction.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvPrediction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showDeliveryData()
        {
            this.db = new MGREntities();
            dgvDelivery.DataSource = db.v_Dostawa.ToList();
            dgvDelivery.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showData()
        {
            showDeliveryData();
            showPredictionData();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                List<v_Popyt_prediction> searchProductNo = db.v_Popyt_prediction.Where(a => a.Nr_produktu == noProductInt).ToList();
                if (searchProductNo.Count() > 0)
                {
                    this.dgvPrediction.DataSource = searchProductNo;
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
            showData();
        }
        private void cbProducentData()
        {
            cbProducent.DataSource = this.db.Dostawca.ToList();
            cbProducent.ValueMember = "ID_dostawca";
            cbProducent.DisplayMember = "Nazwa";
        }

        private void cbPracownikData()
        {
            cbPracownik.DataSource = this.db.v_Pracownik_stanowisko.Where(a => a.Stanowisko == "Magazynier").ToList();
            cbPracownik.ValueMember = "ID_pracownik";
            cbPracownik.DisplayMember = "Nazwisko";
        }


        private void AddToList_Click(object sender, EventArgs e)
        { 
            int selectedPRacownikINT = int.Parse(cbPracownik.SelectedValue.ToString());
            int selectedDostawcaINT = int.Parse(cbProducent.SelectedValue.ToString());
            Dostawa newDostawa = new Dostawa();
            newDostawa.ID_dostawca = selectedDostawcaINT;
            newDostawa.ID_pracownik = selectedPRacownikINT;
            newDostawa.Data_dostawa = dtpDeliveryDate.Value.Date;
            this.db.Dostawa.Add(newDostawa);
            this.db.SaveChanges();
            MessageBox.Show("Skonstruowano nową dostawę!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showDeliveryData();
            int counterOfferDetailsBeforeAgain = this.db.Dostawa_szczegol.Count();
            MessageBox.Show("Dodaj szczegóły dostawy!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MagazynDostawaProdoktowDetails magazynDostawaProdoktowDetails = new MagazynDostawaProdoktowDetails(db, newDostawa);
            magazynDostawaProdoktowDetails.ShowDialog();
            int counterOfferDetailsAfterAgain = this.db.Dostawa_szczegol.Count();
                if (counterOfferDetailsAfterAgain > counterOfferDetailsBeforeAgain)
                {
                    MessageBox.Show("Poprawnie zrealizowano dostawę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDeliveryData();
                }
                else
                {
                    MessageBox.Show("Wprowadź szczegóły dostawy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DostawaNo = int.Parse(this.dgvDelivery.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć dostawę?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Dostawa selectedDostawa = this.db.Dostawa.Single(a => a.ID_dostawa == DostawaNo);
                    this.db.Dostawa.Remove(selectedDostawa);
                    List<Dostawa_szczegol> selectDostawaDeteils = this.db.Dostawa_szczegol.Where(a => a.ID_dostawa == DostawaNo).ToList();
                    this.db.Dostawa_szczegol.RemoveRange(selectDostawaDeteils);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć dostawy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int selectedOrderDetails = int.Parse(this.dgvDelivery.CurrentRow.Cells[0].Value.ToString());
            Dostawa selectedOrder = this.db.Dostawa.Single(a => a.ID_dostawa == selectedOrderDetails);
            MagazynDostawaProdoktowDetails dostawa_Szczegol = new MagazynDostawaProdoktowDetails(db, selectedOrder);
            dostawa_Szczegol.ShowDialog();
        }
    }
    }
 

