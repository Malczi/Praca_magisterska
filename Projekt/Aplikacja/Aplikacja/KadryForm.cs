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
    public partial class KadryForm : Form
    {
        MGREntities db;
        public KadryForm(MGREntities db)
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            this.db = new MGREntities();
            this.dgvAllPracownicy.DataSource = db.v_Pracownik_add.ToList();
            dgvAllPracownicy.Columns[0].Visible = false;
            this.dgvAllPracownicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KadryNowyPracownik kadryNowyPracownik = new KadryNowyPracownik(db);
            kadryNowyPracownik.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int PracownikNo = int.Parse(this.dgvAllPracownicy.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć pracownika?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Pracownik selectedWorker = this.db.Pracownik.Single(a => a.ID_pracownik == PracownikNo);
                    this.db.Pracownik.Remove(selectedWorker);
                    List<Dane_adresowe_pracownik> selectDaneAdresowe = this.db.Dane_adresowe_pracownik.Where(a => a.ID_pracownik == PracownikNo).ToList();
                    this.db.Dane_adresowe_pracownik.RemoveRange(selectDaneAdresowe);
                    List<Nr_telefon_pracownik> selectTelefon = this.db.Nr_telefon_pracownik.Where(a => a.ID_pracownik == PracownikNo).ToList();
                    this.db.Nr_telefon_pracownik.RemoveRange(selectTelefon);
                    List<Email_pracownik> selectEmail = this.db.Email_pracownik.Where(a => a.ID_pracownik == PracownikNo).ToList();
                    this.db.Email_pracownik.RemoveRange(selectEmail);
                    this.db.SaveChanges();
                    showData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć oferty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbPesel.Text.Length > 0)
                choose = "PESEL";
            if (tbSurname.Text.Length > 0)
                choose = "Surname";
            if (tbName.Text.Length > 0)
                choose = "Name";
            switch (choose)
            {
                case "PESEL":
                    searchPESEL();
                    break;
                case "Surname":
                    searchSurname();
                    break;
                case "Name":
                    searchName();
                    break;

            }
        }
        private void searchName()
        {
            try
            {

                List<v_Pracownik_add> searchPracownik = db.v_Pracownik_add.Where(a => a.Imię == tbName.Text).ToList();
                if (searchPracownik.Count() > 0)
                {
                    this.dgvAllPracownicy.DataSource = searchPracownik;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbName.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchSurname()
        {
            try
            {

                List<v_Pracownik_add> searchPracownik = db.v_Pracownik_add.Where(a => a.Nazwisko == tbSurname.Text).ToList();
                if (searchPracownik.Count() > 0)
                {
                    this.dgvAllPracownicy.DataSource = searchPracownik;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbSurname.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void searchPESEL()
        {
            try
            {
                
                List<v_Pracownik_add> searchPracownik = db.v_Pracownik_add.Where(a => a.PESEL == tbPesel.Text).ToList();
                if (searchPracownik.Count() > 0)
                {
                    this.dgvAllPracownicy.DataSource = searchPracownik;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer sprzedaży: {tbPesel.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru sprzedaży!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void messageBox(string searchSalesNo)
        {
            MessageBox.Show($"{searchSalesNo} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cleanTextBox()
        {
            tbPesel.Clear();
            tbSurname.Clear();
        }

        private void msgCleanShowData(string searchSalesNo)
        {
            messageBox(searchSalesNo);
            cleanTextBox();
            showData();
        }


        private void btnGarden_Click(object sender, EventArgs e)
        {
            KadryPracownikEdycja kadryPracownikEdycja = new KadryPracownikEdycja(db);
            kadryPracownikEdycja.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient_form klient_Form = new Klient_form(db);
            klient_Form.ShowDialog();
            this.Close();
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
    }
}
