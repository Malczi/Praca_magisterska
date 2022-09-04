
namespace Aplikacja
{
    partial class SprzedazStatystyki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnDetal = new System.Windows.Forms.Button();
            this.btnHurt = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetal
            // 
            this.btnDetal.Location = new System.Drawing.Point(69, 12);
            this.btnDetal.Name = "btnDetal";
            this.btnDetal.Size = new System.Drawing.Size(125, 52);
            this.btnDetal.TabIndex = 1;
            this.btnDetal.Text = "Statystyki dochodwe sprzedaży detalicznej";
            this.btnDetal.UseVisualStyleBackColor = true;
            this.btnDetal.Click += new System.EventHandler(this.btnDetal_Click);
            // 
            // btnHurt
            // 
            this.btnHurt.Location = new System.Drawing.Point(236, 12);
            this.btnHurt.Name = "btnHurt";
            this.btnHurt.Size = new System.Drawing.Size(125, 52);
            this.btnHurt.TabIndex = 2;
            this.btnHurt.Text = "Statystyki dochodwe sprzedaży hurtowej";
            this.btnHurt.UseVisualStyleBackColor = true;
            this.btnHurt.Click += new System.EventHandler(this.btnHurt_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Image = global::Aplikacja.Properties.Resources.close;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(1201, 9);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 50);
            this.Cancel.TabIndex = 110;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 103);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Detal";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1240, 557);
            this.chart1.TabIndex = 111;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 103);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Hurt";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1240, 557);
            this.chart2.TabIndex = 112;
            this.chart2.Text = "chart2";
            // 
            // SprzedazStatystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnHurt);
            this.Controls.Add(this.btnDetal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SprzedazStatystyki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SprzedazStatystyki";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetal;
        private System.Windows.Forms.Button btnHurt;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}