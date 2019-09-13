namespace BilkentKafe
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
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisDetayEkle = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ADET = new System.Windows.Forms.Label();
            this.cboUrunler = new System.Windows.Forms.ComboBox();
            this.nudUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(771, 283);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(62, 21);
            this.lblOdemeTutari.TabIndex = 0;
            this.lblOdemeTutari.Text = "00,00₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(661, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödeme Tutarı";
            // 
            // btnSiparisDetayEkle
            // 
            this.btnSiparisDetayEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSiparisDetayEkle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetayEkle.Location = new System.Drawing.Point(324, 45);
            this.btnSiparisDetayEkle.Name = "btnSiparisDetayEkle";
            this.btnSiparisDetayEkle.Size = new System.Drawing.Size(113, 33);
            this.btnSiparisDetayEkle.TabIndex = 2;
            this.btnSiparisDetayEkle.Text = "EKLE";
            this.btnSiparisDetayEkle.UseVisualStyleBackColor = false;
            this.btnSiparisDetayEkle.Click += new System.EventHandler(this.btnSiparisDetayEkle_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOdemeAl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdemeAl.Location = new System.Drawing.Point(765, 331);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(139, 67);
            this.btnOdemeAl.TabIndex = 3;
            this.btnOdemeAl.Text = "Ödeme Alındı Hesabı Kapat";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSiparisIptal.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiparisIptal.Location = new System.Drawing.Point(612, 331);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(135, 67);
            this.btnSiparisIptal.TabIndex = 4;
            this.btnSiparisIptal.Text = "Tüm Siparişleri İptal Et";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜN";
            // 
            // ADET
            // 
            this.ADET.AutoSize = true;
            this.ADET.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ADET.Location = new System.Drawing.Point(174, 25);
            this.ADET.Name = "ADET";
            this.ADET.Size = new System.Drawing.Size(42, 16);
            this.ADET.TabIndex = 6;
            this.ADET.Text = "ADET";
            // 
            // cboUrunler
            // 
            this.cboUrunler.BackColor = System.Drawing.Color.MistyRose;
            this.cboUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUrunler.FormattingEnabled = true;
            this.cboUrunler.Location = new System.Drawing.Point(29, 54);
            this.cboUrunler.Name = "cboUrunler";
            this.cboUrunler.Size = new System.Drawing.Size(140, 23);
            this.cboUrunler.TabIndex = 7;
            // 
            // nudUrunAdet
            // 
            this.nudUrunAdet.Location = new System.Drawing.Point(177, 55);
            this.nudUrunAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUrunAdet.Name = "nudUrunAdet";
            this.nudUrunAdet.Size = new System.Drawing.Size(140, 23);
            this.nudUrunAdet.TabIndex = 8;
            this.nudUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.AllowUserToAddRows = false;
            this.dgvSiparisDetaylar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylar.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(29, 96);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.ReadOnly = true;
            this.dgvSiparisDetaylar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSiparisDetaylar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(563, 395);
            this.dgvSiparisDetaylar.TabIndex = 9;
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnaSayfa.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnaSayfa.Location = new System.Drawing.Point(612, 405);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(292, 85);
            this.btnAnaSayfa.TabIndex = 10;
            this.btnAnaSayfa.Text = "<-- ANASAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMasaNo.Location = new System.Drawing.Point(646, 96);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(220, 156);
            this.lblMasaNo.TabIndex = 11;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.nudUrunAdet);
            this.Controls.Add(this.cboUrunler);
            this.Controls.Add(this.ADET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisDetayEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOdemeTutari);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisDetayEkle;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnSiparisIptal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ADET;
        private System.Windows.Forms.ComboBox cboUrunler;
        private System.Windows.Forms.NumericUpDown nudUrunAdet;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label lblMasaNo;
    }
}