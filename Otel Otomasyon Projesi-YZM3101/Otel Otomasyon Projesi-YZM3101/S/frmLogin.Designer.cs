namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmLogin
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtKAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(112, 103);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtKAd
            // 
            this.txtKAd.Location = new System.Drawing.Point(112, 23);
            this.txtKAd.Name = "txtKAd";
            this.txtKAd.Size = new System.Drawing.Size(187, 20);
            this.txtKAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(112, 60);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(187, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(224, 103);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 23);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "Kayit Ol";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 145);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKAd);
            this.Controls.Add(this.btnGiris);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtKAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

