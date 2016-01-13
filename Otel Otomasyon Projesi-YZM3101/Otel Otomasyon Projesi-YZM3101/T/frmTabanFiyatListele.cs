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
    public partial class frmTabanFiyatListele : Form
    {
        public frmTabanFiyatListele()
        {
            InitializeComponent();
        }

        private void frmTabanFiyatBelirle_Load(object sender, EventArgs e)
        {
            

            List<tblTabanFiyatlar> tabanFiyatListesi = new List<tblTabanFiyatlar>();
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    foreach (tblTabanFiyatlar tbn in db.tblTabanFiyatlar.ToList())
                    {
                        tabanFiyatListesi.Add(tbn);
                    }
                }
                DataTable dtTabanFiyatlar = new DataTable();
                dtTabanFiyatlar.Columns.Add("ID");
                dtTabanFiyatlar.Columns.Add("Taban Fiyat");
                dtTabanFiyatlar.Columns.Add("Başlangıç Tarihi");
                dtTabanFiyatlar.Columns.Add("Bitiş Tarihi");

                foreach (tblTabanFiyatlar tbn in tabanFiyatListesi)
                {
                    dtTabanFiyatlar.Rows.Add(tbn.tabanFiyatID, tbn.tabanFiyat, tbn.tanımlandigiTarih, tbn.sonGecerlilikTarihi);
                }
                dtgTabanFiyatlar.DataSource = dtTabanFiyatlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message) ;
            }
        }

        private void btnTabanFiyatBelirle_Click(object sender, EventArgs e)
        {
            frmTabanFiyatEkle ekle = new frmTabanFiyatEkle();
            ekle.Show();
            this.Close();
        }
    }
}
