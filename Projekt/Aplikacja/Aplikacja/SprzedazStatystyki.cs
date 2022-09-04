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
    public partial class SprzedazStatystyki : Form
    {
        MGREntities db;
        public SprzedazStatystyki(MGREntities db)
        {
            InitializeComponent();
            this.db = db;
            hideAllCharts();
        }

        private void chartDetal()
        {
            List<v_All_detal_sold_products> chartColumnData = this.db.v_All_detal_sold_products.ToList();
            chart1.DataSource = chartColumnData;
            chart1.Series["Detal"].XValueMember = "Nazwa_produktu";
            chart1.Series["Detal"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Detal"].YValueMembers = "Przychód";
            chart1.Series["Detal"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void chartHurt()
        {
            List<v_All_hurt_sold_products> chartColumnData = this.db.v_All_hurt_sold_products.ToList();
            chart2.DataSource = chartColumnData;
            chart2.Series["Hurt"].XValueMember = "Nazwa_produktu";
            chart2.Series["Hurt"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart2.Series["Hurt"].YValueMembers = "Przychód";
            chart2.Series["Hurt"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetal_Click(object sender, EventArgs e)
        {
            chart2.Hide();
            chartDetal();
            chart1.Show();
        }

        private void btnHurt_Click(object sender, EventArgs e)
        {
            chart1.Hide();
            chartHurt();
            chart2.Show();
        }

        private void hideAllCharts()
        {
            chart1.Hide();
            chart2.Hide();
        }

    }
}
