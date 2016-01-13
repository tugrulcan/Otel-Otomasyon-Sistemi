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
    public partial class frmRezervasyonYapma : Form
    {
        public frmRezervasyonYapma()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            RezervasyonView RV = new RezervasyonView();
            MusteriView MV = new MusteriView();
            KartView KV = new KartView();
            KullaniciId KI = new KullaniciId();

            DateTime baslangic;
            DateTime bitis;
            DateTime KartSonKullanma;
            string ad, soyad, eposta, kartnumarasi, kartAd, guvenlikKodu;

            baslangic = dateTimePicker1.Value.Date;
            bitis = dateTimePicker2.Value.Date;
            RV.BaslangicTarihi = baslangic;
            RV.BitisTarihi = bitis;
            RV.RezervasyonOlusturmaTarihi = DateTime.Now.Date;

            ad = txtMusteriAd.Text;
            soyad = txtMusteriSoyad.Text;
            eposta = txtMusteriHesap.Text;

            MV.MusteriAd = ad;
            MV.MusteriSoyad = soyad;
            MV.MusteriEPosta = eposta;
            MV.KullaniciId = KI.getKullanici();

            kartnumarasi = txtKartNo.Text;
            kartAd = txtKartAd.Text;
            guvenlikKodu = txtGuvenlikKod.Text;
            KartSonKullanma = dateSonKullanma.Value;


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Güncel Tarihten Daha Önce Bir Tarih Seçemezsiniz.");
                dateTimePicker1.Value = DateTime.Now.Date;
            }
            if(cmbRezerveTip.Items.ToString() == "Ön Ödemeli Rezervasyon")
            {
                if(dateTimePicker1.Value.Date < DateTime.Now.Date.AddDays(90))
                {
                    MessageBox.Show("On ödemeli rezervasyon en az 90 gün önceden yapılmalı");
                    dateTimePicker1.Value = DateTime.Now.Date;
                }
            }else if(cmbRezerveTip.Items.ToString() == "60 Gün Önceden Rezervasyon")
            {
                if (dateTimePicker1.Value.Date < DateTime.Now.Date.AddDays(60))
                {
                    MessageBox.Show("60 Gün Önceden rezervasyon en az 60 gün önceden yapılmalı");
                    dateTimePicker1.Value = DateTime.Now.Date;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Önce Olamaz.");
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if(dateSonKullanma.Value.Date.Year < DateTime.Now.Date.Year)
            {
                MessageBox.Show("Güncel Yıldan Önce Yıl Giremezsiniz");
                dateSonKullanma.Value = DateTime.Now.Date;
            }
        }

        private void frmRezervasyonYapma_Load(object sender, EventArgs e)
        {
            List<tblRezervasyonTipleri> rtip ;
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    rtip = db.tblRezervasyonTipleri.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            List<string> liste = RezervasyonIslem.RezerveTipleri();
            foreach(var i in liste)
            {
                cmbRezerveTip.Items.Add(i);
            }
        }
    }
}
