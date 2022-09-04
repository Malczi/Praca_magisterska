using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja
{
    public partial class chartMagazyny : Form
    {
        MGREntities db;
        public chartMagazyny(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            showChart();
        }

        private void chartMagazine()
        {
            chartMagazyn.DataSource = this.db.v_Procent_magazyn.ToList(); ;
            chartMagazyn.Series["Magazyn"].XValueMember = "Numer_magazynu";
            chartMagazyn.Series["Magazyn"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMagazyn.Series["Magazyn"].YValueMembers = "Procent";
            chartMagazyn.Series["Magazyn"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }
        private void showChart()
        {
            chartMagazine();
            chartMagazyn.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
