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
    public partial class Bath_products_form : Form
    {
        MGREntities db;
        public Bath_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            initDataGridView();
        }

        private void initDataGridView()
        {
            btnAllFromCategory.DataSource = db.v_Dzial_lazienka.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.btnAllFromCategory.Columns[5].Visible = false;
            this.btnAllFromCategory.Columns[0].HeaderText = "Nazwa";
            this.btnAllFromCategory.Columns[1].HeaderText = "Cena netto";
            this.btnAllFromCategory.Columns[2].HeaderText = "Typ produktu";
            this.btnAllFromCategory.Columns[6].HeaderText = "Gwarancja (lata)";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Kitchen_products_form kitchen_Products_Form = new Kitchen_products_form(db);
            kitchen_Products_Form.ShowDialog();
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

        private void btnMebLaz_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Kategoria_meble_lazienkowe.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLustrLaz_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Kategoria_lustra_lazienkowe.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnWanny_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Kategoria_wanny.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnToalety_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Kategoria_toalety.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPryszAkc_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Kategoria_prysznice_akcesoria.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnAllFromCategory.DataSource = db.v_Dzial_lazienka.ToList();
            btnAllFromCategory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.btnAllFromCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
