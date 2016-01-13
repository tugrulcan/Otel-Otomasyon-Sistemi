using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_Otomasyon_Projesi_YZM3101.IsKatmani;

namespace Otel_Otomasyon_Projesi_YZM3101
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string KAd, Sifre, Sonuc;

            KAd = txtKAd.Text;
            Sifre = txtSifre.Text;

            Sonuc = KullaniciIslemleri.Login(KAd, Sifre);
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Giriş Yapıldı");
                frmRezervasyon FR = new frmRezervasyon();
                FR.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKayit FK = new frmKayit();
            FK.Show();
        }
    }
}
