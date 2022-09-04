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
   
    public partial class Bulid_products_form : Form
    {
        MGREntities db;
        public Bulid_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();

        }

        private void initDataGridView()
        {
            dgvBulid_prods.DataSource = db.v_Dzial_budowa.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBulid_prods.Columns[5].Visible = false;
            this.dgvBulid_prods.Columns[0].HeaderText = "Nazwa";
            this.dgvBulid_prods.Columns[1].HeaderText = "Cena netto";
            this.dgvBulid_prods.Columns[2].HeaderText = "Typ produktu";
            this.dgvBulid_prods.Columns[6].HeaderText = "Gwarancja (lata)";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatBud_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Kategoria_mat_bud.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDrewBud_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Kategoria_drew_bud.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDrzwi_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Kategoria_drzwi.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOkna_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Kategoria_okna.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSchody_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Kategoria_schody_balustrady.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGarden_Click(object sender, EventArgs e)
        {
            Garden_products_form garden_Products_Form = new Garden_products_form(db);
            garden_Products_Form.ShowDialog();
            this.Close();
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            Technic_products_form technic_Products_Form = new Technic_products_form(db);
            technic_Products_Form.ShowDialog();
            this.Close();
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            Flat_products_form flat_Products_Form = new Flat_products_form(db);
            flat_Products_Form.ShowDialog();
            this.Close();
        }

        private void btnKitch_Click(object sender, EventArgs e)
        {
            Kitchen_products_form kitchen_Products_Form = new Kitchen_products_form(db);
            kitchen_Products_Form.ShowDialog();
            this.Close();
        }

        private void btnBath_Click(object sender, EventArgs e)
        {
            Bath_products_form bath_Products_Form = new Bath_products_form(db);
            bath_Products_Form.ShowDialog();
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            dgvBulid_prods.DataSource = db.v_Dzial_budowa.ToList();
            dgvBulid_prods.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvBulid_prods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
