namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmMusteriCheckin
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
            this.btnCheckin = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbOdaSayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckin
            // 
            this.btnCheckin.Location = new System.Drawing.Point(110, 75);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(147, 30);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(110, 12);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(147, 21);
            this.cmbMusteri.TabIndex = 1;
            this.cmbMusteri.Text = "Seçiniz";
            // 
            // cmbOdaSayisi
            // 
            this.cmbOdaSayisi.FormattingEnabled = true;
            this.cmbOdaSayisi.Location = new System.Drawing.Point(110, 39);
            this.cmbOdaSayisi.Name = "cmbOdaSayisi";
            this.cmbOdaSayisi.Size = new System.Drawing.Size(147, 21);
            this.cmbOdaSayisi.TabIndex = 2;
            this.cmbOdaSayisi.Text = "Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odalar";
            // 
            // frmMusteriCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdaSayisi);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.btnCheckin);
            this.Name = "frmMusteriCheckin";
            this.Text = "frmMusteriCheckin";
            this.Load += new System.EventHandler(this.frmMusteriCheckin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbOdaSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}