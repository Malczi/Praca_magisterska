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
    public partial class Flat_products_form : Form
    {
        MGREntities db;
        public Flat_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            dgvFlat_prods.DataSource = db.v_Dzial_mieszkanie.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFlat_prods.Columns[5].Visible = false;
            this.dgvFlat_prods.Columns[0].HeaderText = "Nazwa";
            this.dgvFlat_prods.Columns[1].HeaderText = "Cena netto";
            this.dgvFlat_prods.Columns[2].HeaderText = "Typ produktu";
            this.dgvFlat_prods.Columns[6].HeaderText = "Gwarancja (lata)";
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

        private void btnOswietlenie_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Kategoria_oswietlenie.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFarbyILakiery_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Kategoria_farby_lakiery.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMeble_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Kategoria_meble.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPodłogi_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Kategoria_podlogi.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTapety_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Kategoria_tapety.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgvFlat_prods.DataSource = db.v_Dzial_mieszkanie.ToList();
            dgvFlat_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvFlat_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
