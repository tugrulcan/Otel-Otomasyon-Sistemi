namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmTabanFiyatEkle
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
            this.lblTabanFiyat = new System.Windows.Forms.Label();
            this.txtTabanFiyat = new System.Windows.Forms.TextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTabanFiyat
            // 
            this.lblTabanFiyat.AutoSize = true;
            this.lblTabanFiyat.Location = new System.Drawing.Point(12, 19);
            this.lblTabanFiyat.Name = "lblTabanFiyat";
            this.lblTabanFiyat.Size = new System.Drawing.Size(65, 13);
            this.lblTabanFiyat.TabIndex = 0;
            this.lblTabanFiyat.Text = "Taban Fiyatı";
            // 
            // txtTabanFiyat
            // 
            this.txtTabanFiyat.Location = new System.Drawing.Point(83, 16);
            this.txtTabanFiyat.Name = "txtTabanFiyat";
            this.txtTabanFiyat.Size = new System.Drawing.Size(41, 20);
            this.txtTabanFiyat.TabIndex = 1;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(146, 54);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(146, 96);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 20);
            this.dtpBitis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Son Geçerli Tarihi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Geçerlilik Başlangıç Tarihi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(214, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Taban Fiyatını Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmTabanFiyatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 180);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.txtTabanFiyat);
            this.Controls.Add(this.lblTabanFiyat);
            this.Name = "frmTabanFiyatEkle";
            this.Text = "frmTabanFiyatEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabanFiyat;
        private System.Windows.Forms.TextBox txtTabanFiyat;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
    }
}