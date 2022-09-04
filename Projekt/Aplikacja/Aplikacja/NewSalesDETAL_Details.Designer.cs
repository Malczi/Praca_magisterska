
namespace Aplikacja
{
    partial class NewSalesDETAL_Details
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddToList = new System.Windows.Forms.Button();
            this.tbValueProd = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddNewDetalSale = new System.Windows.Forms.Button();
            this.dgvShopList = new System.Windows.Forms.DataGridView();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbJednostka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPodatek = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Ilość:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Produkt:";
            // 
            // AddToList
            // 
            this.AddToList.FlatAppearance.BorderSize = 0;
            this.AddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToList.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToList.Image = global::Aplikacja.Properties.Resources.add;
            this.AddToList.Location = new System.Drawing.Point(1152, 10);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(100, 75);
            this.AddToList.TabIndex = 75;
            this.AddToList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click_1);
            // 
            // tbValueProd
            // 
            this.tbValueProd.Location = new System.Drawing.Point(718, 69);
            this.tbValueProd.Name = "tbValueProd";
            this.tbValueProd.Size = new System.Drawing.Size(100, 20);
            this.tbValueProd.TabIndex = 74;
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Image = global::Aplikacja.Properties.Resources.close;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(1212, 628);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 50);
            this.Cancel.TabIndex = 72;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewDetalSale
            // 
            this.AddNewDetalSale.FlatAppearance.BorderSize = 0;
            this.AddNewDetalSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewDetalSale.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewDetalSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddNewDetalSale.Image = global::Aplikacja.Properties.Resources.check;
            this.AddNewDetalSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewDetalSale.Location = new System.Drawing.Point(476, 628);
            this.AddNewDetalSale.Name = "AddNewDetalSale";
            this.AddNewDetalSale.Size = new System.Drawing.Size(42, 50);
            this.AddNewDetalSale.TabIndex = 71;
            this.AddNewDetalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewDetalSale.UseVisualStyleBackColor = true;
            this.AddNewDetalSale.Click += new System.EventHandler(this.AddNewDetalSale_Click);
            // 
            // dgvShopList
            // 
            this.dgvShopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShopList.Location = new System.Drawing.Point(476, 99);
            this.dgvShopList.Name = "dgvShopList";
            this.dgvShopList.Size = new System.Drawing.Size(776, 523);
            this.dgvShopList.TabIndex = 70;
            this.dgvShopList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShopList_CellContentClick);
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(541, 28);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(605, 21);
            this.cbProducts.TabIndex = 78;
            // 
            // cbJednostka
            // 
            this.cbJednostka.FormattingEnabled = true;
            this.cbJednostka.Location = new System.Drawing.Point(1077, 68);
            this.cbJednostka.Name = "cbJednostka";
            this.cbJednostka.Size = new System.Drawing.Size(69, 21);
            this.cbJednostka.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1012, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Jednostka:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(541, 69);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Cena netto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Podatek:";
            // 
            // cbPodatek
            // 
            this.cbPodatek.FormattingEnabled = true;
            this.cbPodatek.Location = new System.Drawing.Point(898, 69);
            this.cbPodatek.Name = "cbPodatek";
            this.cbPodatek.Size = new System.Drawing.Size(91, 21);
            this.cbPodatek.TabIndex = 84;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Aplikacja.Properties.Resources.search;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(367, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 45);
            this.button2.TabIndex = 109;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(304, 43);
            this.label14.TabIndex = 108;
            this.label14.Text = "Szczegóły sprzedaży";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Numer produktu:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(103, 65);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(249, 20);
            this.tbNumber.TabIndex = 106;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 99);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(439, 523);
            this.dgvProducts.TabIndex = 105;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Aplikacja.Properties.Resources.refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(409, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 45);
            this.button1.TabIndex = 110;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Aplikacja.Properties.Resources.trash;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1164, 628);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 50);
            this.button3.TabIndex = 111;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewSalesDETAL_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cbPodatek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJednostka);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.tbValueProd);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddNewDetalSale);
            this.Controls.Add(this.dgvShopList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewSalesDETAL_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSalesDETAL_Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShopList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.TextBox tbValueProd;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddNewDetalSale;
        private System.Windows.Forms.DataGridView dgvShopList;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ComboBox cbJednostka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPodatek;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}