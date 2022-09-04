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
    public partial class KadryNowyPracownik : Form
    {
        MGREntities db;
        public KadryNowyPracownik(MGREntities db)
        {
            InitializeComponent();
            showData();
            this.db = db;
            cbWyksztalcenieData();
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvWorkersData.DataSource = db.v_Pracownik_add.ToList();
            dgvWorkersData.Columns[0].Visible = false;
            this.dgvWorkersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbWyksztalcenieData()
        {
            cbWyksztalcenie.DataSource = this.db.Wyksztalcenie.ToList();
            cbWyksztalcenie.ValueMember = "ID_wyksztalcenie";
            cbWyksztalcenie.DisplayMember = "Nazwa";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbKodPocztowy.Text) ||
               String.IsNullOrEmpty(tbMiasto.Text) || String.IsNullOrEmpty(tbNrBudynku.Text) || String.IsNullOrEmpty(tbNrDowodu.Text) || String.IsNullOrEmpty(tbNrLokalu.Text)
               || String.IsNullOrEmpty(tbNrTel.Text) || String.IsNullOrEmpty(tbPESEL.Text) || String.IsNullOrEmpty(tbUlica.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedWyksztalcenieInt = int.Parse(cbWyksztalcenie.SelectedValue.ToString());
                Pracownik newPracownik = new Pracownik();
                newPracownik.ID_wyksztalcenie = selectedWyksztalcenieInt;
                newPracownik.Imie = tbName.Text;
                newPracownik.Nazwisko = tbSurname.Text;
                newPracownik.Nr_dowodu = tbNrDowodu.Text;
                newPracownik.PESEL = tbPESEL.Text;
                this.db.Pracownik.Add(newPracownik);
                this.db.SaveChanges();
                Dane_adresowe_pracownik newDaneAdresowePracownik = new Dane_adresowe_pracownik();
                newDaneAdresowePracownik.ID_pracownik = newPracownik.ID_pracownik;
                newDaneAdresowePracownik.Miejscowosc = tbMiasto.Text;
                newDaneAdresowePracownik.Ulica = tbUlica.Text;
                newDaneAdresowePracownik.Nr_budynku = int.Parse(tbNrBudynku.Text);
                newDaneAdresowePracownik.Nr_lokalu = int.Parse(tbNrLokalu.Text);
                newDaneAdresowePracownik.Kod_pocztowy = tbKodPocztowy.Text;
                newDaneAdresowePracownik.Data_od = dtpDate.Value.Date;
                this.db.Dane_adresowe_pracownik.Add(newDaneAdresowePracownik);
                this.db.SaveChanges();
                Nr_telefon_pracownik newNrTelefonPracownik = new Nr_telefon_pracownik();
                newNrTelefonPracownik.ID_pracownik = newPracownik.ID_pracownik;
                newNrTelefonPracownik.Numer = tbNrTel.Text;
                newNrTelefonPracownik.Data_od = dtpDate.Value.Date;
                this.db.Nr_telefon_pracownik.Add(newNrTelefonPracownik);
                this.db.SaveChanges();
                Email_pracownik newEmailPracownik = new Email_pracownik();
                newEmailPracownik.ID_pracownik = newPracownik.ID_pracownik;
                newEmailPracownik.Email = tbNrTel.Text;
                newEmailPracownik.Data_od = dtpDate.Value.Date;
                this.db.Email_pracownik.Add(newEmailPracownik);
                this.db.SaveChanges();
                showData();
                MessageBox.Show("Dodano nowego pracownika!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
