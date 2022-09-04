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
    public partial class Klient_form : Form
    {
        MGREntities db;
        public Klient_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            cleanTextBox();
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

        private void button9_Click(object sender, EventArgs e)
        {
            cleanTextBox();
            showData();
        }

        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgCleanShowData(string searchKlient)
        {
            messageBox(searchKlient);
            cleanTextBox();
            showData();
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvAllKlient.DataSource = db.v_All_clients.ToList();
            this.dgvAllKlient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllKlient.Columns[6].Visible = false;
            this.dgvAllKlient.Columns[2].HeaderText = "Numer telefonu";
            this.dgvAllKlient.Columns[3].HeaderText = "Status klienta";
            this.dgvAllKlient.Columns[4].HeaderText = "Adres e-mail";
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
                List<v_All_clients> searchClientNo = db.v_All_clients.Where(a => a.Numer_telefonu == tbNazwa.Text).ToList();
                if (searchClientNo.Count() > 0)
                {
                    this.dgvAllKlient.DataSource = searchClientNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer telefonu: {tbNazwa.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru telefonu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedRowINT = int.Parse(this.dgvAllKlient.CurrentRow.Cells[6].Value.ToString());
            Klient selectedKlient = db.Klient.Single(a => a.ID_klient == selectedRowINT);
            if (selectedRowINT != 0)
            {
                DialogResult result = MessageBox.Show($"Czy chcesz usunąć klienta: {selectedKlient.Imie} {selectedKlient.Nazwisko}?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.db.Klient.Remove(selectedKlient);

                        this.db.SaveChanges();
                        MessageBox.Show("Klient został usunięty z bazy danych!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Klient widnieje w historii zamówień. Nie można usunąć go usuąć", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            HistoriaZakupowForm historiaZakupowForm = new HistoriaZakupowForm(db);
            historiaZakupowForm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNewClient addNewClient = new AddNewClient(db);
            addNewClient.ShowDialog();        
        }

        private void btnGarden_Click(object sender, EventArgs e)
        {
            KlientEdit_FORM klientEdit_FORM = new KlientEdit_FORM(db);
            klientEdit_FORM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesTypeForm salesTypeForm = new SalesTypeForm(db);
            salesTypeForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MagazynForm magazynForm = new MagazynForm(db);
            magazynForm.ShowDialog();
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
