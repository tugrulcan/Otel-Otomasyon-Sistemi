using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyon_Projesi_YZM3101.M
{
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int rezervasyonID = Convert.ToInt32(txtRezervasyonID.Text);
            richTextBox1.Text = IsKatmani.KullaniciIslemleri.Fatura(rezervasyonID);
        }
    }
}
