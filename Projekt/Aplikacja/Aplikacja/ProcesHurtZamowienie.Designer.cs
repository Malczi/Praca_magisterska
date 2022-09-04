
namespace Aplikacja
{
    partial class ProcesHurtZamowienie
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbWorkerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWorkerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDealNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.dgvDeal = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbClientSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.dtpDateorder = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStanRealizacji = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddNewDetalSale = new System.Windows.Forms.Button();
            this.tbOfferNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "Nazwisko pracownika:";
            // 
            // tbWorkerSurname
            // 
            this.tbWorkerSurname.Location = new System.Drawing.Point(908, 74);
            this.tbWorkerSurname.Name = "tbWorkerSurname";
            this.tbWorkerSurname.Size = new System.Drawing.Size(100, 20);
            this.tbWorkerSurname.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = "Imię pracownika:";
            // 
            // tbWorkerName
            // 
            this.tbWorkerName.Location = new System.Drawing.Point(687, 74);
            this.tbWorkerName.Name = "tbWorkerName";
            this.tbWorkerName.Size = new System.Drawing.Size(100, 20);
            this.tbWorkerName.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Numer umowy:";
            // 
            // tbDealNo
            // 
            this.tbDealNo.Location = new System.Drawing.Point(687, 12);
            this.tbDealNo.Name = "tbDealNo";
            this.tbDealNo.Size = new System.Drawing.Size(100, 20);
            this.tbDealNo.TabIndex = 146;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(471, 43);
            this.label14.TabIndex = 143;
            this.label14.Text = "Zamówienie sprzedaży hurtowej";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "Numer umowy:";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(125, 70);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(138, 20);
            this.tbNumber.TabIndex = 141;
            // 
            // dgvDeal
            // 
            this.dgvDeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeal.Location = new System.Drawing.Point(25, 104);
            this.dgvDeal.Name = "dgvDeal";
            this.dgvDeal.Size = new System.Drawing.Size(475, 504);
            this.dgvDeal.TabIndex = 140;
            this.dgvDeal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeal_CellContentClick);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(520, 104);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(726, 504);
            this.dgvOrders.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 155;
            this.label5.Text = "Nazwisko klienta:";
            // 
            // tbClientSurname
            // 
            this.tbClientSurname.Location = new System.Drawing.Point(908, 42);
            this.tbClientSurname.Name = "tbClientSurname";
            this.tbClientSurname.Size = new System.Drawing.Size(100, 20);
            this.tbClientSurname.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 153;
            this.label6.Text = "Imię klienta:";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(687, 42);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 152;
            // 
            // dtpDateorder
            // 
            this.dtpDateorder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateorder.Location = new System.Drawing.Point(908, 13);
            this.dtpDateorder.Name = "dtpDateorder";
            this.dtpDateorder.Size = new System.Drawing.Size(99, 20);
            this.dtpDateorder.TabIndex = 156;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 157;
            this.label7.Text = "Data zamówienia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1022, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 158;
            this.label8.Text = "Stan realzacji:";
            // 
            // cbStanRealizacji
            // 
            this.cbStanRealizacji.FormattingEnabled = true;
            this.cbStanRealizacji.Location = new System.Drawing.Point(1101, 11);
            this.cbStanRealizacji.Name = "cbStanRealizacji";
            this.cbStanRealizacji.Size = new System.Drawing.Size(121, 21);
            this.cbStanRealizacji.TabIndex = 159;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Image = global::Aplikacja.Properties.Resources.pencil;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1098, 626);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 50);
            this.btnEdit.TabIndex = 160;
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
            this.button3.Location = new System.Drawing.Point(455, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 48);
            this.button3.TabIndex = 145;
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
            this.button2.Location = new System.Drawing.Point(407, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 48);
            this.button2.TabIndex = 144;
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
            this.button1.Location = new System.Drawing.Point(1146, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 50);
            this.button1.TabIndex = 139;
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
            this.AddToList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddToList.Location = new System.Drawing.Point(1025, 70);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(221, 28);
            this.AddToList.TabIndex = 138;
            this.AddToList.Text = "Dodaj zamówienie";
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
            this.Cancel.Location = new System.Drawing.Point(1204, 626);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(42, 50);
            this.Cancel.TabIndex = 137;
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
            this.AddNewDetalSale.Location = new System.Drawing.Point(25, 626);
            this.AddNewDetalSale.Name = "AddNewDetalSale";
            this.AddNewDetalSale.Size = new System.Drawing.Size(42, 50);
            this.AddNewDetalSale.TabIndex = 136;
            this.AddNewDetalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewDetalSale.UseVisualStyleBackColor = true;
            this.AddNewDetalSale.Click += new System.EventHandler(this.AddNewDetalSale_Click);
            // 
            // tbOfferNo
            // 
            this.tbOfferNo.Location = new System.Drawing.Point(1101, 42);
            this.tbOfferNo.Name = "tbOfferNo";
            this.tbOfferNo.Size = new System.Drawing.Size(121, 20);
            this.tbOfferNo.TabIndex = 161;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1018, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 162;
            this.label9.Text = "Numer umowy:";
            // 
            // ProcesHurtZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 688);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbOfferNo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbStanRealizacji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbClientSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWorkerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWorkerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDealNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.dgvDeal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddNewDetalSale);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesHurtZamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcesHurtZamowienie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWorkerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWorkerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDealNo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.DataGridView dgvDeal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddNewDetalSale;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbClientSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.DateTimePicker dtpDateorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStanRealizacji;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbOfferNo;
        private System.Windows.Forms.Label label9;
    }
}