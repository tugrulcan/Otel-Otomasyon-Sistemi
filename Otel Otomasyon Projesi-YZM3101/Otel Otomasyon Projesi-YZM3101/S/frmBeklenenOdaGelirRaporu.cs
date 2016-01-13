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
namespace Otel_Otomasyon_Projesi_YZM3101.S
{
    public partial class frmBeklenenOdaGelirRaporu : Form
    {
        public frmBeklenenOdaGelirRaporu()
        {
            InitializeComponent();
        }

        private void frmBeklenenOdaGelirRaporu_Load(object sender, EventArgs e)
        {
            decimal? toplamUcret = KullaniciIslemler.BeklenenOdaGelirRaporu();
            int kacKisi = KullaniciIslemler.BeklenenOdaGelirRaporuCount();
            DataTable dt = new DataTable();
            dt.Columns.Add("Toplam Ucret");
            dt.Columns.Add("Ortalam Ucret");

            dt.Rows.Add(toplamUcret, kacKisi);
        }
    }
}
