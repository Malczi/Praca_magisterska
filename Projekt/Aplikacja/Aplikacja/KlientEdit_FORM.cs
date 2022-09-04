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
    public partial class KlientEdit_FORM : Form
    {
        MGREntities db;
        public KlientEdit_FORM(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showData();
            StatusKlientData();
        }

        private void StatusKlientData()
        {
            cbStatusClient.DataSource = this.db.Status_klient.ToList();
            cbStatusClient.ValueMember = "ID_status_klient";
            cbStatusClient.DisplayMember = "Nazwa";
        }
        private void showData()
        {
            dgvKlientEdit.DataSource = db.v_Edit_client.ToList();
            dgvKlientEdit.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKlientEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKlientEdit.Columns[0].Visible = false;
            this.dgvKlientEdit.Columns[3].HeaderText = "Nazwa firmy";
            this.dgvKlientEdit.Columns[5].HeaderText = "Nr telefonu (1)";
            this.dgvKlientEdit.Columns[6].HeaderText = "Nr telefonu (2)";
            this.dgvKlientEdit.Columns[9].HeaderText = "Kod pocztowy";
            this.dgvKlientEdit.Columns[11].HeaderText = "Nr domu";
            this.dgvKlientEdit.Columns[12].HeaderText = "Nr lokalu";
            this.dgvKlientEdit.Columns[13].HeaderText = "Status klienta";

        }

        private void dgvKlientEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbSurname.Text = this.dgvKlientEdit.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = this.dgvKlientEdit.CurrentRow.Cells[2].Value.ToString();
            tbCompany.Text = this.dgvKlientEdit.CurrentRow.Cells[3].Value.ToString();
            tbNIP.Text = this.dgvKlientEdit.CurrentRow.Cells[4].Value.ToString();
            tbNo1.Text = this.dgvKlientEdit.CurrentRow.Cells[5].Value.ToString();
            //tbNo2.Text = this.dgvKlientEdit.CurrentRow.Cells[6].Value.ToString();
            tbEmail.Text = this.dgvKlientEdit.CurrentRow.Cells[7].Value.ToString();
            tbCity.Text = this.dgvKlientEdit.CurrentRow.Cells[8].Value.ToString();
            tbPostCode.Text = this.dgvKlientEdit.CurrentRow.Cells[9].Value.ToString();
            tbStreet.Text = this.dgvKlientEdit.CurrentRow.Cells[10].Value.ToString();
            tbHomeNo.Text = this.dgvKlientEdit.CurrentRow.Cells[11].Value.ToString();
            tbLocalNo.Text = this.dgvKlientEdit.CurrentRow.Cells[12].Value.ToString();
            cbStatusClient.Text = this.dgvKlientEdit.CurrentRow.Cells[13].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbNo1.Text) || String.IsNullOrEmpty(tbCity.Text) ||
               String.IsNullOrEmpty(tbPostCode.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedStustusInt = int.Parse(cbStatusClient.SelectedValue.ToString());
                int currentID = int.Parse(dgvKlientEdit.CurrentRow.Cells[0].Value.ToString());
                string newSurname = tbSurname.Text;
                string newName = tbName.Text;
                string newCompany = tbCompany.Text;
                string newNIP = tbNIP.Text;
                string newNo1 = tbNo1.Text;
                string newNo2 = tbNo2.Text;
                string newEmail = tbEmail.Text;
                string newCity = tbCity.Text;
                string newPostCode = tbPostCode.Text;
                string newStreet = tbStreet.Text;
                int newHomeNo = int.Parse(tbHomeNo.Text);
                int newLocalNo = int.Parse(tbLocalNo.Text);
                int newStatusID = int.Parse(cbStatusClient.SelectedValue.ToString());
                Klient result = db.Klient.SingleOrDefault(b => b.ID_klient == currentID);
                if (result != null)
                {
                    result.Nazwisko = newSurname;
                    result.Imie = newName;
                    result.Nazwa_firmy = newCompany;
                    result.NIP = newNIP;
                    result.Nr_telefonu_1 = newNo1;
                    result.Nr_telefonu_2 = newNo2;
                    result.Email = newEmail;
                    result.Miasto = newCity;
                    result.Kod_pocztowy = newPostCode;
                    result.Ulica = newStreet;
                    result.Nr_domu = newHomeNo;
                    result.Nr_lokalu = newLocalNo;
                    result.ID_status_klient = newStatusID;
                    db.SaveChanges();
                }
                MessageBox.Show("Poprawnie zaktualizowano.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
