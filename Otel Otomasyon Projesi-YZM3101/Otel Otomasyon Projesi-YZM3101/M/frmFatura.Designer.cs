namespace Otel_Otomasyon_Projesi_YZM3101.M
{
    partial class frmFatura
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
            this.txtRezervasyonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFatura = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtRezervasyonID
            // 
            this.txtRezervasyonID.Location = new System.Drawing.Point(98, 11);
            this.txtRezervasyonID.Name = "txtRezervasyonID";
            this.txtRezervasyonID.Size = new System.Drawing.Size(149, 20);
            this.txtRezervasyonID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RezervasyonID";
            // 
            // btnFatura
            // 
            this.btnFatura.Location = new System.Drawing.Point(361, 8);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(75, 23);
            this.btnFatura.TabIndex = 5;
            this.btnFatura.Text = "Göster";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 342);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 392);
            this.Controls.Add(this.txtRezervasyonID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFatura);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmFatura";
            this.Text = "frmFatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRezervasyonID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}