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
    public partial class Technic_products_form : Form
    {
        MGREntities db;
        public Technic_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvTech_prods.DataSource = db.v_Dzial_technika.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTech_prods.Columns[5].Visible = false;
            this.dgvTech_prods.Columns[0].HeaderText = "Nazwa";
            this.dgvTech_prods.Columns[1].HeaderText = "Cena netto";
            this.dgvTech_prods.Columns[2].HeaderText = "Typ produktu";
            this.dgvTech_prods.Columns[6].HeaderText = "Gwarancja (lata)";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBudowa_Click(object sender, EventArgs e)
        {
            Bulid_products_form bulid_Products_Form = new Bulid_products_form(db);
            bulid_Products_Form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Garden_products_form garden_Products_Form = new Garden_products_form(db);
            garden_Products_Form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flat_products_form flat_Products_Form = new Flat_products_form(db);
            flat_Products_Form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitchen_products_form kitchen_Products_Form = new Kitchen_products_form(db);
            kitchen_Products_Form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bath_products_form bath_Products_Form = new Bath_products_form(db);
            bath_Products_Form.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            All_products_form all_Products_form = new All_products_form(db);
            all_Products_form.ShowDialog();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void btnMaszOgr_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Kategoria_elektr_narz.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLampZew_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Kategoria_recz_narz.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRosliny_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Kategoria_duze_maszyny.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOdsnieZamia_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Kategoria_odsniez_zamiat.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGrill_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Kategoria_masz_czysz.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvTech_prods.DataSource = db.v_Dzial_technika.ToList();
            dgvTech_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvTech_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
