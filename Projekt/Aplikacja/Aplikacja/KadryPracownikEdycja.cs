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
    public partial class KadryPracownikEdycja : Form
    {
        MGREntities db;
        public KadryPracownikEdycja(MGREntities db)
        {
            InitializeComponent();
            showData();
            cbWyksztalcenieData();
        }

        private void cbWyksztalcenieData()
        {
            cbWyksztalcenie.DataSource = this.db.Wyksztalcenie.ToList();
            cbWyksztalcenie.ValueMember = "ID_wyksztalcenie";
            cbWyksztalcenie.DisplayMember = "Nazwa";
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvWorkersData.DataSource = db.v_Pracownik_add.ToList();
            dgvWorkersData.Columns[0].Visible = false;
            this.dgvWorkersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgvWorkersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = this.dgvWorkersData.CurrentRow.Cells[1].Value.ToString();
            tbSurname.Text = this.dgvWorkersData.CurrentRow.Cells[2].Value.ToString();
            cbWyksztalcenie.Text = this.dgvWorkersData.CurrentRow.Cells[3].Value.ToString();
            tbNrTel.Text = this.dgvWorkersData.CurrentRow.Cells[4].Value.ToString();
            tbEmail.Text = this.dgvWorkersData.CurrentRow.Cells[5].Value.ToString();
            tbMiasto.Text = this.dgvWorkersData.CurrentRow.Cells[6].Value.ToString();
            tbKodPocztowy.Text = this.dgvWorkersData.CurrentRow.Cells[7].Value.ToString();
            tbUlica.Text = this.dgvWorkersData.CurrentRow.Cells[8].Value.ToString();
            tbNrBudynku.Text = this.dgvWorkersData.CurrentRow.Cells[9].Value.ToString();
            tbNrLokalu.Text = this.dgvWorkersData.CurrentRow.Cells[10].Value.ToString();
            tbNrDowodu.Text = this.dgvWorkersData.CurrentRow.Cells[11].Value.ToString();
            tbPESEL.Text = this.dgvWorkersData.CurrentRow.Cells[12].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbNrTel.Text) || String.IsNullOrEmpty(tbEmail.Text) ||
               String.IsNullOrEmpty(tbMiasto.Text) || String.IsNullOrEmpty(tbKodPocztowy.Text) || String.IsNullOrEmpty(tbUlica.Text) || String.IsNullOrEmpty(tbNrBudynku.Text)
               || String.IsNullOrEmpty(tbNrLokalu.Text) || String.IsNullOrEmpty(tbNrDowodu.Text) || String.IsNullOrEmpty(tbPESEL.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int currentID = int.Parse(dgvWorkersData.CurrentRow.Cells[0].Value.ToString());
                string newSurname = tbSurname.Text;
                string newName = tbName.Text;
                int newWyksztalcenieID = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                string newNrTel = tbNrTel.Text;
                string newMail = tbEmail.Text;
                string newMiasto = tbMiasto.Text;
                string newKodPocztowy = tbKodPocztowy.Text;
                string newUlica = tbUlica.Text;
                int newNrBudynku = int.Parse(tbNrBudynku.Text);
                int newNrLokalu = int.Parse(tbNrLokalu.Text);
                string newNrDowodu = tbNrDowodu.Text;
                string newPESEL = tbPESEL.Text;
                Pracownik result = db.Pracownik.SingleOrDefault(b => b.ID_pracownik == currentID);
                Dane_adresowe_pracownik resultAdres = db.Dane_adresowe_pracownik.SingleOrDefault(c => c.ID_pracownik == currentID);
                Nr_telefon_pracownik resultTelefon = db.Nr_telefon_pracownik.SingleOrDefault(c => c.ID_pracownik == currentID);
                Email_pracownik resultEmail = db.Email_pracownik.SingleOrDefault(c => c.ID_pracownik == currentID);
                if (result != null)
                {
                    result.Nazwisko = newSurname;
                    result.Imie = newName;
                    result.ID_wyksztalcenie = newWyksztalcenieID;
                    result.Nr_dowodu = newNrDowodu;
                    result.PESEL = newPESEL;
                    resultAdres.Miejscowosc = newMiasto;
                    resultAdres.Ulica = newUlica;
                    resultAdres.Nr_budynku = newNrBudynku;
                    resultAdres.Nr_lokalu = newNrLokalu;
                    resultAdres.Kod_pocztowy = newKodPocztowy;
                    resultAdres.Data_od = dtpDate.Value.Date;
                    resultTelefon.Data_od = dtpDate.Value.Date;
                    resultTelefon.Numer = newNrTel;
                    resultEmail.Data_od = dtpDate.Value.Date;
                    resultEmail.Email = newMail;

                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
