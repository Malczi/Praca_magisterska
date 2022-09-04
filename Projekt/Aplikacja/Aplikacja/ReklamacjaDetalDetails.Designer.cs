
namespace Aplikacja
{
    partial class ReklamacjaDetalDetails
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
            this.cbComplaintType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.dgvSalesDetails = new System.Windows.Forms.DataGridView();
            this.tbUwagi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvComplaintDetails = new System.Windows.Forms.DataGridView();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.chbUtylizacja = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProdukt = new System.Windows.Forms.TextBox();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cbComplaintType
            // 
            this.cbComplaintType.FormattingEnabled = true;
            this.cbComplaintType.Location = new System.Drawing.Point(981, 35);
            this.cbComplaintType.Name = "cbComplaintType";
            this.cbComplaintType.Size = new System.Drawing.Size(135, 21);
            this.cbComplaintType.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 223;
            this.label8.Text = "Szczegóły reklamacji";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 222;
            this.label7.Text = "Szczegóły sprzedaży detalicznej";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 221;
            this.label6.Text = "Uwagi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 220;
            this.label5.Text = "Produkt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 219;
            this.label3.Text = "Typ reklamacji:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 217;
            this.label1.Text = "Nazwa produktu:";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(16, 155);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(501, 20);
            this.tbProductNo.TabIndex = 209;
            // 
            // dgvSalesDetails
            // 
            this.dgvSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesDetails.Location = new System.Drawing.Point(16, 200);
            this.dgvSalesDetails.Name = "dgvSalesDetails";
            this.dgvSalesDetails.Size = new System.Drawing.Size(597, 410);
            this.dgvSalesDetails.TabIndex = 208;
            this.dgvSalesDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesDetails_CellContentClick);
            // 
            // tbUwagi
            // 
            this.tbUwagi.Location = new System.Drawing.Point(659, 85);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(597, 20);
            this.tbUwagi.TabIndex = 207;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(481, 43);
            this.label14.TabIndex = 204;
            this.label14.Text = "Szczegóły reklamacji detalicznej";
            // 
            // dgvComplaintDetails
            // 
            this.dgvComplaintDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaintDetails.Location = new System.Drawing.Point(659, 200);
            this.dgvComplaintDetails.Name = "dgvComplaintDetails";
            this.dgvComplaintDetails.Size = new System.Drawing.Size(597, 410);
            this.dgvComplaintDetails.TabIndex = 203;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(1147, 36);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(58, 20);
            this.tbAmount.TabIndex = 226;
            // 
            // chbUtylizacja
            // 
            this.chbUtylizacja.AutoSize = true;
            this.chbUtylizacja.Location = new System.Drawing.Point(1147, 62);
            this.chbUtylizacja.Name = "chbUtylizacja";
            this.chbUtylizacja.Size = new System.Drawing.Size(71, 17);
            this.chbUtylizacja.TabIndex = 227;
            this.chbUtylizacja.Text = "Utylizacja";
            this.chbUtylizacja.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1144, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 228;
            this.label4.Text = "Ilość:";
            // 
            // cbProdukt
            // 
            this.cbProdukt.Location = new System.Drawing.Point(659, 36);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(316, 20);
            this.cbProdukt.TabIndex = 229;
            // 
            // btnRef
            // 
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRef.Image = global::Aplikacja.Properties.Resources.refresh;
            this.btnRef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRef.Location = new System.Drawing.Point(571, 136);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(42, 48);
            this.btnRef.TabIndex = 215;
            this.btnRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Image = global::Aplikacja.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(523, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 48);
            this.btnSearch.TabIndex = 214;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.FlatAppearance.BorderSize = 0;
            this.btnDelate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelate.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelate.Image = global::Aplikacja.Properties.Resources.trash;
            this.btnDelate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelate.Location = new System.Drawing.Point(1147, 620);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(42, 50);
            this.btnDelate.TabIndex = 213;
            this.btnDelate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelate.UseVisualStyleBackColor = true;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // AddToList
            // 
            this.AddToList.FlatAppearance.BorderSize = 0;
            this.AddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToList.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddToList.Image = global::Aplikacja.Properties.Resources.add;
            this.AddToList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddToList.Location = new System.Drawing.Point(659, 117);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(597, 64);
            this.AddToList.TabIndex = 212;
            this.AddToList.Text = "Dodaj szczegół";
            this.AddToList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Image = global::Aplikacja.Properties.Resources.close;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1205, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 50);
            this.btnCancel.TabIndex = 211;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Image = global::Aplikacja.Properties.Resources.check;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(26, 620);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(42, 50);
            this.btnOK.TabIndex = 210;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ReklamacjaDetalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbUtylizacja);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.cbComplaintType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbProductNo);
            this.Controls.Add(this.dgvSalesDetails);
            this.Controls.Add(this.tbUwagi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvComplaintDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReklamacjaDetalDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReklamacjaDetalDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaintDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComplaintType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.DataGridView dgvSalesDetails;
        private System.Windows.Forms.TextBox tbUwagi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvComplaintDetails;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.CheckBox chbUtylizacja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cbProdukt;
    }
}