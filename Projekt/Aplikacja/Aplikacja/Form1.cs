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
    public partial class StartForm : Form
    {
        MGREntities db = new MGREntities();

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            All_products_form all_Products_form = new All_products_form(db);
            all_Products_form.ShowDialog();
            this.Close();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Bulid_products_form bulid_Products_Form = new Bulid_products_form(db);
            bulid_Products_Form.ShowDialog();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Add_products_form add_Products_Form = new Add_products_form(db);
            add_Products_Form.ShowDialog();
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

        private void button5_Click(object sender, EventArgs e)
        {
            KadryForm kadryForm = new KadryForm(db);
            kadryForm.ShowDialog();
            this.Close();
        }
    }
}
