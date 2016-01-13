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
    public partial class frmGunlukGelenlerRaporu : Form
    {
        public frmGunlukGelenlerRaporu()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dtgGunlukGelenler.DataSource = IsKatmani.KullaniciIslemleri.GunlukGelenlerRaporu();

        }
    }
}
