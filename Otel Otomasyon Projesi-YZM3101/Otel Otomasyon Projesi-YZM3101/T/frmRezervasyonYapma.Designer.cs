namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmRezervasyonYapma
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriHesap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuvenlikKod = new System.Windows.Forms.TextBox();
            this.txtKartAd = new System.Windows.Forms.TextBox();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.dateSonKullanma = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbRezerveTip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(126, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMusteriHesap);
            this.groupBox1.Controls.Add(this.txtMusteriSoyad);
            this.groupBox1.Controls.Add(this.txtMusteriAd);
            this.groupBox1.Location = new System.Drawing.Point(31, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(76, 31);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(161, 20);
            this.txtMusteriAd.TabIndex = 0;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(77, 67);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(161, 20);
            this.txtMusteriSoyad.TabIndex = 1;
            // 
            // txtMusteriHesap
            // 
            this.txtMusteriHesap.Location = new System.Drawing.Point(77, 99);
            this.txtMusteriHesap.Name = "txtMusteriHesap";
            this.txtMusteriHesap.Size = new System.Drawing.Size(161, 20);
            this.txtMusteriHesap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-posta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateSonKullanma);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtGuvenlikKod);
            this.groupBox2.Controls.Add(this.txtKartAd);
            this.groupBox2.Controls.Add(this.txtKartNo);
            this.groupBox2.Location = new System.Drawing.Point(31, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 182);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Kart Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Güvenlik Kodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kart Uzerindeki Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kart Numarası";
            // 
            // txtGuvenlikKod
            // 
            this.txtGuvenlikKod.Location = new System.Drawing.Point(116, 126);
            this.txtGuvenlikKod.Name = "txtGuvenlikKod";
            this.txtGuvenlikKod.Size = new System.Drawing.Size(159, 20);
            this.txtGuvenlikKod.TabIndex = 2;
            // 
            // txtKartAd
            // 
            this.txtKartAd.Location = new System.Drawing.Point(116, 67);
            this.txtKartAd.Name = "txtKartAd";
            this.txtKartAd.Size = new System.Drawing.Size(159, 20);
            this.txtKartAd.TabIndex = 1;
            // 
            // txtKartNo
            // 
            this.txtKartNo.Location = new System.Drawing.Point(115, 31);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(159, 20);
            this.txtKartNo.TabIndex = 0;
            // 
            // dateSonKullanma
            // 
            this.dateSonKullanma.Location = new System.Drawing.Point(115, 98);
            this.dateSonKullanma.Name = "dateSonKullanma";
            this.dateSonKullanma.Size = new System.Drawing.Size(159, 20);
            this.dateSonKullanma.TabIndex = 6;
            this.dateSonKullanma.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Son Kullanma Tarihi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(31, 482);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(308, 41);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Rezervasyon Yap";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbRezerveTip
            // 
            this.cmbRezerveTip.FormattingEnabled = true;
            this.cmbRezerveTip.Location = new System.Drawing.Point(126, 15);
            this.cmbRezerveTip.Name = "cmbRezerveTip";
            this.cmbRezerveTip.Size = new System.Drawing.Size(213, 21);
            this.cmbRezerveTip.TabIndex = 7;
            this.cmbRezerveTip.Text = "Seçiniz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Rezervasyon Tipi";
            // 
            // frmRezervasyonYapma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 535);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRezerveTip);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmRezervasyonYapma";
            this.Text = "frmAnaSayfa";
            this.Load += new System.EventHandler(this.frmRezervasyonYapma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriHesap;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGuvenlikKod;
        private System.Windows.Forms.TextBox txtKartAd;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateSonKullanma;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbRezerveTip;
        private System.Windows.Forms.Label label10;
    }
}