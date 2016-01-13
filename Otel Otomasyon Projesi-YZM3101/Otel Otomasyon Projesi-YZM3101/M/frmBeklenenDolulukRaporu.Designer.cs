namespace Otel_Otomasyon_Projesi_YZM3101.M
{
    partial class frmBeklenenDolulukRaporu
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
            this.dtgBeklenenDolulukRaporu = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBeklenenDolulukRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBeklenenDolulukRaporu
            // 
            this.dtgBeklenenDolulukRaporu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBeklenenDolulukRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBeklenenDolulukRaporu.Location = new System.Drawing.Point(12, 49);
            this.dtgBeklenenDolulukRaporu.Name = "dtgBeklenenDolulukRaporu";
            this.dtgBeklenenDolulukRaporu.Size = new System.Drawing.Size(420, 333);
            this.dtgBeklenenDolulukRaporu.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListele.Location = new System.Drawing.Point(357, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmBeklenenDolulukRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 394);
            this.Controls.Add(this.dtgBeklenenDolulukRaporu);
            this.Controls.Add(this.btnListele);
            this.Name = "frmBeklenenDolulukRaporu";
            this.Text = "frmBeklenenDolulukRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBeklenenDolulukRaporu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBeklenenDolulukRaporu;
        private System.Windows.Forms.Button btnListele;

    }
}