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
    public partial class Add_products_form : Form
    {
        MGREntities db;

        public Add_products_form(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showDataBox();
        }

        private void showDataBox()
        {
            cbTypeData();
            cbGwarancjaData();
            cbProducentData();
            cbDzialData();
            cbKategoriaData();
            cbPodkategoriaData();
        }

        private void cbGwarancjaData()
        {
            cbGwarancja.DataSource = this.db.Gwarancja.ToList();
            cbGwarancja.ValueMember = "ID_gwarancja";
            cbGwarancja.DisplayMember = "Opis_gwarancja";
        }

        private void cbProducentData()
        {
            cbProducent.DataSource = this.db.v_Producent_alpha.ToList();
            cbProducent.ValueMember = "ID";
            cbProducent.DisplayMember = "Nazwa";
        }

        private void cbDzialData()
        {
            cbDzial.DataSource = this.db.v_Dzial_alpha.ToList();
            cbDzial.ValueMember = "ID";
            cbDzial.DisplayMember = "Nazwa";
        }

        private void cbKategoriaData()
        {  
            cbKategoria.DataSource = this.db.v_Kategoria_alpha.ToList();
            cbKategoria.ValueMember = "ID";
            cbKategoria.DisplayMember = "Nazwa";
        }

        private void cbPodkategoriaData()
        {
            cbPodkategoria.DataSource = this.db.v_Podkategoria_alpha.ToList();
            cbPodkategoria.ValueMember = "ID";
            cbPodkategoria.DisplayMember = "Nazwa";
        }

        private void cbTypeData()
        {
            cbType.DataSource = this.db.v_Typ_alpha_2.ToList();
            cbType.ValueMember = "ID";
            cbType.DisplayMember = "Nazwa";
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
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbNumber.Text) || String.IsNullOrEmpty(tbPrice.Text)
                || String.IsNullOrEmpty(tbMagazyn.Text) || String.IsNullOrEmpty(tbPrzydatnosc.Text) || String.IsNullOrEmpty(tbObjetosc.Text))

            {
                MessageBox.Show("Uzupełnij brakujące informacje!");
            }
            else 
            {
                int selectedProducentInt = int.Parse(cbProducent.SelectedValue.ToString());
                int selectedTypeProductInt = int.Parse(cbType.SelectedValue.ToString());
                int selectedGwarancjaInt = int.Parse(cbGwarancja.SelectedValue.ToString());
                Produkt newprodukt = new Produkt();
                newprodukt.Nazwa = tbName.Text;
                newprodukt.Producent = this.db.Producent.Single(a => a.ID_producent == selectedProducentInt);
                newprodukt.Typ_produkt = this.db.Typ_produkt.Single(a => a.ID_typ_produkt == selectedTypeProductInt);
                newprodukt.Nr_produkt = int.Parse(tbNumber.Text);
                newprodukt.Cena_sugerowana_netto = decimal.Parse(tbPrice.Text);
                newprodukt.Termin_magazynowania_miesiace = int.Parse(tbMagazyn.Text);
                newprodukt.Termin_przydatnosci_miesiace = int.Parse(tbPrzydatnosc.Text);
                newprodukt.Objetosc_magazynowa_m3 = decimal.Parse(tbObjetosc.Text);
                newprodukt.Gwarancja = this.db.Gwarancja.Single(a => a.ID_gwarancja == selectedGwarancjaInt);
                this.db.Produkt.Add(newprodukt);
                this.db.SaveChanges();
                MessageBox.Show("Dodano nowy produkt!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_producent_form add_Producent_Form = new Add_producent_form(db);
            add_Producent_Form.ShowDialog();
        }
    }
}
