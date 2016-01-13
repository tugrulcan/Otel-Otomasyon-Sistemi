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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string KAd, Sifre, Sonuc;
            int Id;
            KAd = txtKAd.Text;
            Sifre = txtSifre.Text;
            if (chckYon.Checked)
            {
                Id = 1;
            }
            else
            {
                Id = 0;
            }
            Sonuc = KullaniciIslemler.KullaniciEkle(KAd, Sifre, Id);
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Kayıt Tamamlandı.");
                this.Close();
            }
            else
            {
                MessageBox.Show(Sonuc);
            }
        }
    }
}
