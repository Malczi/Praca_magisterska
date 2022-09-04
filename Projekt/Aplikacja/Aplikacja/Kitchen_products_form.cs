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
    public partial class Kitchen_products_form : Form
    {
        MGREntities db;
        public Kitchen_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvKitch_prods.DataSource = db.v_Dzial_kuchnia.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitch_prods.Columns[5].Visible = false;
            this.dgvKitch_prods.Columns[0].HeaderText = "Nazwa";
            this.dgvKitch_prods.Columns[1].HeaderText = "Cena netto";
            this.dgvKitch_prods.Columns[2].HeaderText = "Typ produktu";
            this.dgvKitch_prods.Columns[6].HeaderText = "Gwarancja (lata)";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Technic_products_form technic_Products_Form = new Technic_products_form(db);
            technic_Products_Form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flat_products_form flat_Products_Form = new Flat_products_form(db);
            flat_Products_Form.ShowDialog();
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

        private void btnAneksy_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Kategoria_aneksy_kuchenne.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBaterKuch_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Kategoria_baterie_kuchenne.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOkapKuch_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Kategoria_okapy_kuchenne.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMebKuch_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Kategoria_meble_kuchenne.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAgd_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Kategoria_AGD.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvKitch_prods.DataSource = db.v_Dzial_kuchnia.ToList();
            dgvKitch_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvKitch_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
