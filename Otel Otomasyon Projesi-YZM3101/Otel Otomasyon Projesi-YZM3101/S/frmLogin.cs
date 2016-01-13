using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_Otomasyon_Projesi_YZM3101.Business_Layer;

namespace Otel_Otomasyon_Projesi_YZM3101
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string KAd, Sifre, Sonuc;
            KAd = txtKAd.Text;
            Sifre = txtSifre.Text;
            Sonuc = KullaniciIslemler.Login(KAd, Sifre);
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Giriş Başarılı");
                frmRezervasyonYapma FAS = new frmRezervasyonYapma();
                FAS.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKayit f = new frmKayit();
            f.Show();
        }
    }
}
