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
    public partial class Add_producent_form : Form
    {
        MGREntities db;
        public Add_producent_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbURL.Text))

            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else
            {
                Producent newproducent = new Producent();
                newproducent.Nazwa = tbName.Text;
                newproducent.Adres_URL = tbURL.Text;
                this.db.Producent.Add(newproducent);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nowego producenta!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
