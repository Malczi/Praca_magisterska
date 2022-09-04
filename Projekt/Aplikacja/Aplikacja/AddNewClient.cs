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
    public partial class AddNewClient : Form
    {
        MGREntities db;
        public AddNewClient(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showDataBox();
            showData();
        }

        private void showData()
        {
            this.db = new MGREntities();
            this.dgvAllClients.DataSource = db.v_All_clients.ToList();
            dgvAllClients.Columns[0].Visible = false;
            this.dgvAllClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDataBox()
        {
            cbStatusClientData();
        }

        private void cbStatusClientData()
        {
            cbStatusClient.DataSource = this.db.Status_klient.ToList();
            cbStatusClient.ValueMember = "ID_status_klient";
            cbStatusClient.DisplayMember = "Nazwa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSurname.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbNo1.Text) || String.IsNullOrEmpty(tbCity.Text) ||
               String.IsNullOrEmpty(tbPostCode.Text) || String.IsNullOrEmpty(tbHomeNo.Text) || String.IsNullOrEmpty(tbLocalNo.Text))
            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                int selectedStustusInt = int.Parse(cbStatusClient.SelectedValue.ToString());
                Klient newklient = new Klient();
                newklient.Nazwisko = tbSurname.Text;
                newklient.Imie = tbName.Text;
                newklient.Nazwa_firmy = tbCompany.Text;
                newklient.NIP = tbNIP.Text;
                newklient.Nr_telefonu_1 = tbNo1.Text;
                newklient.Nr_telefonu_2 = tbNo2.Text;
                newklient.Email = tbEmail.Text;
                newklient.Miasto = tbCity.Text;
                newklient.Kod_pocztowy = tbPostCode.Text;
                newklient.Ulica = tbStreet.Text;
                newklient.Nr_domu = int.Parse(tbHomeNo.Text);
                newklient.Nr_lokalu = int.Parse(tbLocalNo.Text);
                newklient.Status_klient = this.db.Status_klient.Single(a => a.ID_status_klient == selectedStustusInt);
                this.db.Klient.Add(newklient);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nowego klienta!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
