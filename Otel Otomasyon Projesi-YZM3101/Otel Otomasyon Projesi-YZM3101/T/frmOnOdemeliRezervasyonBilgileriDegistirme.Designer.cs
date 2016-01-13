namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmOnOdemeliRezervasyonBilgileriDegistirme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezervasyonID = new System.Windows.Forms.TextBox();
            this.btnRezervasyonGetir = new System.Windows.Forms.Button();
            this.lblBaslangci = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ön ödemeli rezervasyon ID: ";
            // 
            // txtRezervasyonID
            // 
            this.txtRezervasyonID.Location = new System.Drawing.Point(158, 15);
            this.txtRezervasyonID.Name = "txtRezervasyonID";
            this.txtRezervasyonID.Size = new System.Drawing.Size(62, 20);
            this.txtRezervasyonID.TabIndex = 1;
            // 
            // btnRezervasyonGetir
            // 
            this.btnRezervasyonGetir.Location = new System.Drawing.Point(131, 41);
            this.btnRezervasyonGetir.Name = "btnRezervasyonGetir";
            this.btnRezervasyonGetir.Size = new System.Drawing.Size(131, 23);
            this.btnRezervasyonGetir.TabIndex = 2;
            this.btnRezervasyonGetir.Text = "Rezervasyonu Getir";
            this.btnRezervasyonGetir.UseVisualStyleBackColor = true;
            this.btnRezervasyonGetir.Click += new System.EventHandler(this.btnRezervasyonGetir_Click);
            // 
            // lblBaslangci
            // 
            this.lblBaslangci.AutoSize = true;
            this.lblBaslangci.Location = new System.Drawing.Point(12, 158);
            this.lblBaslangci.Name = "lblBaslangci";
            this.lblBaslangci.Size = new System.Drawing.Size(106, 13);
            this.lblBaslangci.TabIndex = 3;
            this.lblBaslangci.Text = "Yeni Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeni Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eski Bitiş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Eski Başlangıç Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(123, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(124, 158);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(123, 184);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rezervasyonu Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOnOdemeliRezervasyonBilgileriDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBaslangci);
            this.Controls.Add(this.btnRezervasyonGetir);
            this.Controls.Add(this.txtRezervasyonID);
            this.Controls.Add(this.label1);
            this.Name = "frmOnOdemeliRezervasyonBilgileriDegistirme";
            this.Text = "frmOnOdemeliRezervasyonBilgileriDegistirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezervasyonID;
        private System.Windows.Forms.Button btnRezervasyonGetir;
        private System.Windows.Forms.Label lblBaslangci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button1;
    }
}