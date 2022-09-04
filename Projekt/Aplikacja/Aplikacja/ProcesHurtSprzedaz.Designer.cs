
namespace Aplikacja
{
    partial class ProcesHurtSprzedaz
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
            this.cbPayForm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateSale = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatePay = new System.Windows.Forms.DateTimePicker();
            this.cbCollectForm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddNewDetalSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPayForm
            // 
            this.cbPayForm.FormattingEnabled = true;
            this.cbPayForm.Location = new System.Drawing.Point(722, 41);
            this.cbPayForm.Name = "cbPayForm";
            this.cbPayForm.Size = new System.Drawing.Size(121, 21);
            this.cbPayForm.TabIndex = 185;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 184;
            this.label8.Text = "Forma płatności:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(849, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 183;
            this.label7.Text = "Data sprzedaży:";
            // 
            // dtpDateSale
            // 
            this.dtpDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSale.Location = new System.Drawing.Point(964, 10);
            this.dtpDateSale.Name = "dtpDateSale";
            this.dtpDateSale.Size = new System.Drawing.Size(99, 20);
            this.dtpDateSale.TabIndex = 182;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 173;
            this.label2.Text = "Numer zamówienia:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(734, 9);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(109, 20);
            this.tbOrderNo.TabIndex = 172;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(271, 43);
            this.label14.TabIndex = 169;
            this.label14.Text = "Sprzedaż hurtowa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "Numer zamowienia:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(126, 67);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(138, 20);
            this.tbNumber.TabIndex = 167;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(26, 101);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(597, 504);
            this.dgvOrders.TabIndex = 166;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(629, 101);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(618, 504);
            this.dgvSales.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 188;
            this.label3.Text = "Termin zapłaty:";
            // 
            // dtpDatePay
            // 
            this.dtpDatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePay.Location = new System.Drawing.Point(964, 42);
            this.dtpDatePay.Name = "dtpDatePay";
            this.dtpDatePay.Size = new System.Drawing.Size(99, 20);
            this.dtpDatePay.TabIndex = 187;
            // 
            // cbCollectForm
            // 
            this.cbCollectForm.FormattingEnabled = true;
            this.cbCollectForm.Location = new System.Drawing.Point(722, 75);
            this.cbCollectForm.Name = "cbCollectForm";
            this.cbCollectForm.Size = new System.Drawing.Size(121, 21);
            this.cbCollectForm.TabIndex = 190;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 189;
            this.label4.Text = "Forma odbioru:";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Image = global::Aplikacja.Properties.Resources.pencil;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1099, 623);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 50);
            this.btnEdit.TabIndex = 186;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Aplikacja.Properties.Resources.refresh;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(525, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 48);
            this.button3.TabIndex = 171;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Aplikacja.Properties.Resources.search;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(477, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 48);
            this.button2.TabIndex = 170;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Aplikacja.Properties.Resources.trash;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1147, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 50);
            this.button1.TabIndex = 165;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddToList
            // 
            this.AddToList.FlatAppearance.BorderSize = 0;
            this.AddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToList.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddToList.Image = global::Aplikacja.Properties.Resources.add;
            this.AddToList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddToList.Location = new System.Drawing.Point(1069, 17);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(178, 67);
            this.AddToList.TabIndex = 164;
            this.AddToList.Text = "Dodaj sprzedaż";
            this.AddToList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Image = global::Aplikacja.Properties.Resources.close;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(1205, 623);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 50);
            this.Cancel.TabIndex = 163;
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
            this.AddNewDetalSale.Location = new System.Drawing.Point(26, 623);
            this.AddNewDetalSale.Name = "AddNewDetalSale";
            this.AddNewDetalSale.Size = new System.Drawing.Size(42, 50);
            this.AddNewDetalSale.TabIndex = 162;
            this.AddNewDetalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewDetalSale.UseVisualStyleBackColor = true;
            this.AddNewDetalSale.Click += new System.EventHandler(this.AddNewDetalSale_Click);
            // 
            // ProcesHurtSprzedaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbCollectForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatePay);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbPayForm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddNewDetalSale);
            this.Controls.Add(this.dgvSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesHurtSprzedaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcesHurtSprzedaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbPayForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddNewDetalSale;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatePay;
        private System.Windows.Forms.ComboBox cbCollectForm;
        private System.Windows.Forms.Label label4;
    }
}