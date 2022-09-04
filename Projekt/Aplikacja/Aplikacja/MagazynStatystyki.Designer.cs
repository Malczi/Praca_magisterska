
namespace Aplikacja
{
    partial class chartMagazyny
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMagazyn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMagazyn)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMagazyn
            // 
            this.chartMagazyn.BackColor = System.Drawing.Color.Transparent;
            this.chartMagazyn.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartMagazyn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMagazyn.Legends.Add(legend2);
            this.chartMagazyn.Location = new System.Drawing.Point(-1, -2);
            this.chartMagazyn.Name = "chartMagazyn";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Magazyn";
            this.chartMagazyn.Series.Add(series2);
            this.chartMagazyn.Size = new System.Drawing.Size(1265, 570);
            this.chartMagazyn.TabIndex = 0;
            this.chartMagazyn.Text = "chart1";
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Image = global::Aplikacja.Properties.Resources.close;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(1210, 619);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 50);
            this.Cancel.TabIndex = 109;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // chartMagazyny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.chartMagazyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chartMagazyny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MagazynStatystyki";
            ((System.ComponentModel.ISupportInitialize)(this.chartMagazyn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMagazyn;
        private System.Windows.Forms.Button Cancel;
    }
}