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
    public partial class MagazynPlanowanyPopyt : Form
    {
        MGREntities db;
        public MagazynPlanowanyPopyt(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
        }

        private void showPredictionData()
        {
            this.db = new MGREntities();
            dgvPrediction.DataSource = db.v_Popyt_prediction.ToList();
            dgvPrediction.Columns[0].Visible = false;
            dgvPrediction.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvPrediction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void showData()
        {
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
            cleanTextBox();
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
