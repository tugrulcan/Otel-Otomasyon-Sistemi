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
    public partial class frmGunlukDolulukOranRaporEkranı : Form
    {
        public frmGunlukDolulukOranRaporEkranı()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string mesaj = dateTimePicker1.Value.Date.Date + " tarihinde "; //toplam oda sayısı bulunacak
            int toplamOdaSayisi = 0, toplamDoluOdaSayisi = 0;
            DateTime secilenTarih = dateTimePicker1.Value.Date;
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    toplamOdaSayisi = db.tblOdalar.ToList().Count();
                    List<int> secilenTarihRezervasyonTarihleri = new List<int>();

                    foreach (tblRezervasyon r in db.tblRezervasyon.ToList())
                    {
                        if(r.baslangicTarihi.Date <= secilenTarih.Date || secilenTarih.Date <= r.bitisTarihi.Date) //secilen tarih için rezervasyonlara bakılıyor.
                        {
                            tblOdalar oda = db.tblOdalar.ToList().FirstOrDefault(x => x.OdaID == r.OdaID);
                            if (oda.OdaDurumKodu == 1)//oda dolu için 1 degerini aldık
                            {
                                toplamDoluOdaSayisi += 1;
                            }
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
           mesaj += toplamOdaSayisi + " adet odadan " + toplamDoluOdaSayisi + " adedi dolu. Doluluk Oranı: " + Convert.ToString(((float)toplamDoluOdaSayisi / (float)toplamOdaSayisi) ) ;
           MessageBox.Show(mesaj);
        }
    }
}
