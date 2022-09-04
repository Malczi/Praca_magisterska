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
    public partial class SalesTypeForm : Form
    {
        MGREntities db;
        public SalesTypeForm(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            startform.ShowDialog();
            this.Close(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klient_form klient_Form = new Klient_form(db);
            klient_Form.ShowDialog();
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesDETALform salesDETALform = new SalesDETALform(db);
            salesDETALform.ShowDialog();
            this.Close();
        }

        private void btnSaleHurt_Click(object sender, EventArgs e)
        {
            SalesHURTform salesHURTform = new SalesHURTform(db);
            salesHURTform.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NewSalesDETAL newSalesDETAL = new NewSalesDETAL(db) ;
            newSalesDETAL.ShowDialog();
            this.Close();
        }

        private void btnMaszOgr_Click(object sender, EventArgs e)
        {
            ProcesHurtOfertaHandlowa procesHurtOfertaHandlowa = new ProcesHurtOfertaHandlowa(db);
            procesHurtOfertaHandlowa.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            SprzedazStatystyki newSprzedazStatystyki = new SprzedazStatystyki(db);
            newSprzedazStatystyki.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReklamacjaDetal reklamacjaDetal = new ReklamacjaDetal(db);
            reklamacjaDetal.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReklamacjaHurt reklamacjaHurt = new ReklamacjaHurt(db);
            reklamacjaHurt.ShowDialog();
        }
    }
}
