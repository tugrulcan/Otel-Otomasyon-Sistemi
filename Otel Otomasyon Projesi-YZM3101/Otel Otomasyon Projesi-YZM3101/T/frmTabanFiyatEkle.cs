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
    public partial class frmTabanFiyatEkle : Form
    {
        public frmTabanFiyatEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<tblTabanFiyatlar> tabanFiyatlar ;
            tblTabanFiyatlar yeniTabanFiyat = new tblTabanFiyatlar() ;
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    tabanFiyatlar = db.tblTabanFiyatlar.ToList();
                    int sonID = tabanFiyatlar.Last().tabanFiyatID;
                    
                    yeniTabanFiyat.tabanFiyat = Convert.ToDecimal(txtTabanFiyat.Text);
                    yeniTabanFiyat.tanımlandigiTarih = dtpBaslangic.Value.Date;
                    yeniTabanFiyat.sonGecerlilikTarihi = dtpBaslangic.Value.Date;
                    yeniTabanFiyat.tabanFiyatID = sonID + 1;

                    db.tblTabanFiyatlar.Add(yeniTabanFiyat);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

            frmTabanFiyatListele belirler = new frmTabanFiyatListele();
            MessageBox.Show("Yeni taban fiyatı başarıyla eklendi");
            this.Close();
            belirler.Show();
        }
    }
}
