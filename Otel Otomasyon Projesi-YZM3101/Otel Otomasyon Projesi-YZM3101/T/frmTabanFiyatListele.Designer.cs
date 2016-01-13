namespace Otel_Otomasyon_Projesi_YZM3101
{
    partial class frmTabanFiyatListele
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgTabanFiyatlar = new System.Windows.Forms.DataGridView();
            this.btnTabanFiyatBelirle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabanFiyatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgTabanFiyatlar);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taban Fiyatları";
            // 
            // dtgTabanFiyatlar
            // 
            this.dtgTabanFiyatlar.AllowUserToAddRows = false;
            this.dtgTabanFiyatlar.AllowUserToDeleteRows = false;
            this.dtgTabanFiyatlar.AllowUserToOrderColumns = true;
            this.dtgTabanFiyatlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgTabanFiyatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabanFiyatlar.Location = new System.Drawing.Point(3, 16);
            this.dtgTabanFiyatlar.Name = "dtgTabanFiyatlar";
            this.dtgTabanFiyatlar.ReadOnly = true;
            this.dtgTabanFiyatlar.Size = new System.Drawing.Size(539, 114);
            this.dtgTabanFiyatlar.TabIndex = 0;
            // 
            // btnTabanFiyatBelirle
            // 
            this.btnTabanFiyatBelirle.Location = new System.Drawing.Point(438, 163);
            this.btnTabanFiyatBelirle.Name = "btnTabanFiyatBelirle";
            this.btnTabanFiyatBelirle.Size = new System.Drawing.Size(116, 23);
            this.btnTabanFiyatBelirle.TabIndex = 1;
            this.btnTabanFiyatBelirle.Text = "Taban Fiyat Ekle";
            this.btnTabanFiyatBelirle.UseVisualStyleBackColor = true;
            this.btnTabanFiyatBelirle.Click += new System.EventHandler(this.btnTabanFiyatBelirle_Click);
            // 
            // frmTabanFiyatBelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 190);
            this.Controls.Add(this.btnTabanFiyatBelirle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTabanFiyatBelirle";
            this.Text = "frmTabanFiyatBelirle";
            this.Load += new System.EventHandler(this.frmTabanFiyatBelirle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabanFiyatlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgTabanFiyatlar;
        private System.Windows.Forms.Button btnTabanFiyatBelirle;
    }
}