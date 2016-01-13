namespace Otel_Otomasyon_Projesi_YZM3101.M
{
    partial class frmGunlukGelenlerRaporu
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
            this.dtgGunlukGelenler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGunlukGelenler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGunlukGelenler
            // 
            this.dtgGunlukGelenler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGunlukGelenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGunlukGelenler.Location = new System.Drawing.Point(12, 46);
            this.dtgGunlukGelenler.Name = "dtgGunlukGelenler";
            this.dtgGunlukGelenler.Size = new System.Drawing.Size(442, 322);
            this.dtgGunlukGelenler.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(379, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmGunlukGelenlerRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 380);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dtgGunlukGelenler);
            this.Name = "frmGunlukGelenlerRaporu";
            this.Text = "frmGunlukGelenlerRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGunlukGelenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGunlukGelenler;
        private System.Windows.Forms.Button btnListele;
    }
}