
namespace AnkaKafe.UI
{
    partial class SiparisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvSiparisDetay = new System.Windows.Forms.DataGridView();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutar = new System.Windows.Forms.Label();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(269, 31);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 22);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvSiparisDetay
            // 
            this.dgvSiparisDetay.AllowUserToAddRows = false;
            this.dgvSiparisDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSiparisDetay.Location = new System.Drawing.Point(10, 57);
            this.dgvSiparisDetay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSiparisDetay.Name = "dgvSiparisDetay";
            this.dgvSiparisDetay.ReadOnly = true;
            this.dgvSiparisDetay.RowHeadersVisible = false;
            this.dgvSiparisDetay.RowHeadersWidth = 51;
            this.dgvSiparisDetay.RowTemplate.Height = 29;
            this.dgvSiparisDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetay.Size = new System.Drawing.Size(458, 370);
            this.dgvSiparisDetay.TabIndex = 2;
            this.dgvSiparisDetay.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSiparisDetay_UserDeletingRow);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(148, 32);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(116, 23);
            this.nudAdet.TabIndex = 3;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboUrun
            // 
            this.cboUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(10, 32);
            this.cboUrun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(133, 23);
            this.cboUrun.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(495, 80);
            this.cboMasaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(133, 23);
            this.cboMasaNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No";
            // 
            // btnTasi
            // 
            this.btnTasi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTasi.Location = new System.Drawing.Point(642, 81);
            this.btnTasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(82, 22);
            this.btnTasi.TabIndex = 8;
            this.btnTasi.Text = "TAŞI";
            this.btnTasi.UseVisualStyleBackColor = true;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMasaNo.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.ForeColor = System.Drawing.Color.White;
            this.lblMasaNo.Location = new System.Drawing.Point(493, 133);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(210, 99);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Tutarı: ";
            // 
            // lblOdemeTutar
            // 
            this.lblOdemeTutar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOdemeTutar.AutoSize = true;
            this.lblOdemeTutar.Location = new System.Drawing.Point(633, 244);
            this.lblOdemeTutar.Name = "lblOdemeTutar";
            this.lblOdemeTutar.Size = new System.Drawing.Size(34, 15);
            this.lblOdemeTutar.TabIndex = 11;
            this.lblOdemeTutar.Text = "7,55₺";
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnİptal.BackColor = System.Drawing.Color.Thistle;
            this.btnİptal.ForeColor = System.Drawing.Color.Maroon;
            this.btnİptal.Location = new System.Drawing.Point(486, 274);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(116, 40);
            this.btnİptal.TabIndex = 12;
            this.btnİptal.Text = "SİPARİŞ İPTAL";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnOde
            // 
            this.btnOde.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOde.BackColor = System.Drawing.Color.GreenYellow;
            this.btnOde.ForeColor = System.Drawing.Color.Maroon;
            this.btnOde.Location = new System.Drawing.Point(608, 274);
            this.btnOde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(116, 40);
            this.btnOde.TabIndex = 13;
            this.btnOde.Text = "ÖDEME AL";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnaSayfa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnaSayfa.Location = new System.Drawing.Point(486, 326);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(238, 42);
            this.btnAnaSayfa.TabIndex = 14;
            this.btnAnaSayfa.Text = "ANA SAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "₺0.00";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Birim Fiyatı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 436);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.lblOdemeTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dgvSiparisDetay);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvSiparisDetay;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdemeTutar;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}