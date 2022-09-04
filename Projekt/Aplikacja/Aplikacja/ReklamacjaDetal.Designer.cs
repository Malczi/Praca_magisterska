
namespace Aplikacja
{
    partial class ReklamacjaDetal
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
            this.dgvComplaint = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDateComplaint = new System.Windows.Forms.DateTimePicker();
            this.cbSalesNumber = new System.Windows.Forms.ComboBox();
            this.tbComplaintText = new System.Windows.Forms.TextBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.tbSalesNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbWorkerSurname = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.AddToList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComplaint
            // 
            this.dgvComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaint.Location = new System.Drawing.Point(655, 198);
            this.dgvComplaint.Name = "dgvComplaint";
            this.dgvComplaint.Size = new System.Drawing.Size(597, 410);
            this.dgvComplaint.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(499, 43);
            this.label14.TabIndex = 170;
            this.label14.Text = "Reklamacja sprzedaży detalicznej";
            // 
            // dtpDateComplaint
            // 
            this.dtpDateComplaint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateComplaint.Location = new System.Drawing.Point(655, 31);
            this.dtpDateComplaint.Name = "dtpDateComplaint";
            this.dtpDateComplaint.Size = new System.Drawing.Size(104, 20);
            this.dtpDateComplaint.TabIndex = 171;
            // 
            // cbSalesNumber
            // 
            this.cbSalesNumber.FormattingEnabled = true;
            this.cbSalesNumber.Location = new System.Drawing.Point(804, 30);
            this.cbSalesNumber.Name = "cbSalesNumber";
            this.cbSalesNumber.Size = new System.Drawing.Size(135, 21);
            this.cbSalesNumber.TabIndex = 172;
            // 
            // tbComplaintText
            // 
            this.tbComplaintText.Location = new System.Drawing.Point(655, 83);
            this.tbComplaintText.Name = "tbComplaintText";
            this.tbComplaintText.Size = new System.Drawing.Size(597, 20);
            this.tbComplaintText.TabIndex = 175;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(12, 198);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(597, 410);
            this.dgvSales.TabIndex = 176;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // tbSalesNumber
            // 
            this.tbSalesNumber.Location = new System.Drawing.Point(12, 153);
            this.tbSalesNumber.Name = "tbSalesNumber";
            this.tbSalesNumber.Size = new System.Drawing.Size(125, 20);
            this.tbSalesNumber.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 194;
            this.label1.Text = "Numer sprzedaży:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 195;
            this.label2.Text = "Data reklamacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 196;
            this.label3.Text = "Numer sprzedaży:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(974, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "Nazwisko pracownika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 199;
            this.label6.Text = "Opis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 200;
            this.label7.Text = "Sprzedaże detaliczne";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 201;
            this.label8.Text = "Reklamacje";
            // 
            // cbWorkerSurname
            // 
            this.cbWorkerSurname.FormattingEnabled = true;
            this.cbWorkerSurname.Location = new System.Drawing.Point(977, 31);
            this.cbWorkerSurname.Name = "cbWorkerSurname";
            this.cbWorkerSurname.Size = new System.Drawing.Size(135, 21);
            this.cbWorkerSurname.TabIndex = 202;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Image = global::Aplikacja.Properties.Resources.pencil;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1095, 618);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 50);
            this.btnEdit.TabIndex = 193;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRef
            // 
            this.btnRef.FlatAppearance.BorderSize = 0;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRef.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRef.Image = global::Aplikacja.Properties.Resources.refresh;
            this.btnRef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRef.Location = new System.Drawing.Point(567, 134);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(42, 48);
            this.btnRef.TabIndex = 192;
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
            this.btnSearch.Location = new System.Drawing.Point(519, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 48);
            this.btnSearch.TabIndex = 191;
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
            this.btnDelate.Location = new System.Drawing.Point(1143, 618);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(42, 50);
            this.btnDelate.TabIndex = 190;
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
            this.AddToList.Location = new System.Drawing.Point(655, 115);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(597, 64);
            this.AddToList.TabIndex = 189;
            this.AddToList.Text = "Dodaj reklamację";
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
            this.btnCancel.Location = new System.Drawing.Point(1201, 618);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 50);
            this.btnCancel.TabIndex = 188;
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
            this.btnOK.Location = new System.Drawing.Point(22, 618);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(42, 50);
            this.btnOK.TabIndex = 187;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ReklamacjaDetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbWorkerSurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbSalesNumber);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.tbComplaintText);
            this.Controls.Add(this.cbSalesNumber);
            this.Controls.Add(this.dtpDateComplaint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvComplaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReklamacjaDetal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReklamacjaDetal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComplaint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDateComplaint;
        private System.Windows.Forms.ComboBox cbSalesNumber;
        private System.Windows.Forms.TextBox tbComplaintText;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox tbSalesNumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbWorkerSurname;
    }
}