using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Otel_Otomasyon_Projesi_YZM3101
{
    public partial class frmOnOdemeliRezervasyonBilgileriDegistirme : Form
    {
        public frmOnOdemeliRezervasyonBilgileriDegistirme()
        {
            InitializeComponent();
        }
        int rezervasyonId = 0;
        tblRezervasyon rezervasyon;
        DBOtelEntities db = new DBOtelEntities();
        private void btnRezervasyonGetir_Click(object sender, EventArgs e)
        {
            rezervasyonId = Convert.ToInt32(txtRezervasyonID.Text);
            try
            {
                
                    rezervasyon = db.tblRezervasyon.ToList().FirstOrDefault(x => x.rezervasyonID == rezervasyonId);
                    if (rezervasyon.rezervasyonTipID != 1) //on odemeli için 1 degeri
                    {
                        MessageBox.Show("Girilen rezervasyon id'si ön ödemeli rezervasyon değildir!");
                    }
                    else
                    {
                        dateTimePicker1.Value = rezervasyon.baslangicTarihi;
                        dateTimePicker2.Value = rezervasyon.bitisTarihi;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezervasyon.baslangicTarihi = dateTimePicker3.Value.Date;
            
            decimal tabanF  =0;
            foreach (tblTabanFiyatlar tbn  in db.tblTabanFiyatlar.ToList())
            {
               if(tbn.tanımlandigiTarih.Date.DayOfYear >= DateTime.Today.DayOfYear|| tbn.sonGecerlilikTarihi.DayOfYear <= DateTime.Today.DayOfYear){
                   tabanF = tbn.tabanFiyat;
               }
            }
            string mesaj = "Rezervasyon tarihi " + rezervasyon.baslangicTarihi.Date.ToShortDateString() + " - " + rezervasyon.bitisTarihi.Date.ToShortDateString() + " olarak değiştirildi. Ceza ücreti: " + Convert.ToString((tabanF) *(decimal)110/(decimal)100) + " ₺";
            MessageBox.Show(mesaj);
            db.SaveChanges();
        }
    }
}
