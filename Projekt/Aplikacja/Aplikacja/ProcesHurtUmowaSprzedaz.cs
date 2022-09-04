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
    public partial class ProcesHurtUmowaSprzedaz : Form
    {
        MGREntities db;
        public ProcesHurtUmowaSprzedaz(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showOfferData();
            showDealData();
        }

        private void showOfferData()
        {
            this.db = new MGREntities();
            this.dgvAkceptedOffers.DataSource = this.db.v_Oferta_handlowa_zaakceptowane.OrderBy(a => a.Numer_oferty).ToList();
            this.dgvAkceptedOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showDealData()
        {
            this.db = new MGREntities();
            this.dgvDealData.DataSource = this.db.v_Umowa_sprzedazy_hurt.OrderBy(a => a.Numer_umowy_sprzedazy).ToList();
            this.dgvDealData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAkceptedOffers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOfferNo.Text = this.dgvAkceptedOffers.CurrentRow.Cells[0].Value.ToString();
            tbWorkerName.Text = this.dgvAkceptedOffers.CurrentRow.Cells[1].Value.ToString();
            tbWorkerSurname.Text = this.dgvAkceptedOffers.CurrentRow.Cells[2].Value.ToString();
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            if (tbPhoneNumber.Text.Length > 0)
            {
                List<Klient> selectClientByNIP = this.db.Klient.Where(a => a.Nr_telefonu_1 == tbPhoneNumber.Text).ToList();
                if (selectClientByNIP.Count() > 0)
                {
                    Klient selectedClient = this.db.Klient.SingleOrDefault(a => a.Nr_telefonu_1 == tbPhoneNumber.Text);
                    if (selectedClient != null)
                    {
                        Umowa_sprzedaz_hurt newUmowa_Sprzedaz_Hurt = new Umowa_sprzedaz_hurt();
                        newUmowa_Sprzedaz_Hurt.ID_klient = selectedClient.ID_klient;
                        newUmowa_Sprzedaz_Hurt.ID_oferta_handlowa = int.Parse(tbOfferNo.Text);
                        this.db.Umowa_sprzedaz_hurt.Add(newUmowa_Sprzedaz_Hurt);
                        this.db.SaveChanges();
                        MessageBox.Show("Podpisano umowę", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showDealData();
                    }
                    else
                    {
                        MessageBox.Show("Wprowadź dane nowego klienta do systemu", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Wprowadzony numer: {tbPhoneNumber.Text} nie jest poprawny!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Błędnie wprowadzono dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewDetalSale_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showDealData();
            showOfferData();
        }

        private void searchNumber()
        {
            try
            {
                int selecedOfferIdInt = int.Parse(tbNumber.Text);
                List<Oferta_handlowa> searchOffertNo = db.Oferta_handlowa.Where(a => a.ID_oferta_handlowa == selecedOfferIdInt).ToList();
                if (searchOffertNo.Count() > 0)
                {
                    this.dgvAkceptedOffers.DataSource = searchOffertNo;
                    cleanTextBox();
                }
                else
                {
                    msgCleanShowData($"Wyszukiwany numer oferty: {tbNumber.Text}");
                }
            }
            catch (Exception)
            {
                cleanTextBox();
                MessageBox.Show("Sprawdź czy nie wprowadziłeś liter do numeru telefonu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanTextBox()
        {
            tbNumber.Clear();
        }
        private void msgCleanShowData(string searchKlient)
        {
            messageBox(searchKlient);
            cleanTextBox();
            showOfferData();
        }
        private void messageBox(string searchKlient)
        {
            MessageBox.Show($"{searchKlient} nie widnieje w bazie danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string choose = "";
            if (tbNumber.Text.Length > 0)
                choose = "Number";
            switch (choose)
            {
                case "Number":
                    searchNumber();
                    break;
                default:
                    wrongData();
                    break;
            }
        }
        private void wrongData()
        {
            MessageBox.Show("Źle wprowadzono dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showOfferData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salesDetailNo = int.Parse(this.dgvDealData.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć umowę?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Umowa_sprzedaz_hurt selectedOferta = this.db.Umowa_sprzedaz_hurt.Single(a => a.ID_umowa_sprzedaz_hurt == salesDetailNo);
                    this.db.Umowa_sprzedaz_hurt.Remove(selectedOferta);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie można usunąć oferty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
