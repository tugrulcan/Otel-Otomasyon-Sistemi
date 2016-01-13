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
    public partial class frmMusteriCheckin : Form
    {
        public frmMusteriCheckin()
        {
            InitializeComponent();
        }

        private void frmMusteriCheckin_Load(object sender, EventArgs e)
        {
            List<int> liste = OdaIslemleri.MusterileriGetir();
            List<string> OdaListe = OdaIslemleri.OdalariGetir();
            foreach(var i in liste)
            {
                cmbMusteri.Items.Add(i);
            }
            foreach(var i in OdaListe)
            {
                cmbOdaSayisi.Items.Add(i);
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            string Sonuc = OdaIslemleri.OdaVer(Convert.ToInt32(cmbMusteri.SelectedItem), Convert.ToInt32(cmbOdaSayisi.SelectedItem));
            if(Sonuc == "yes")
            {
                MessageBox.Show("Oda Tahsis Edildi");
            }
            else
            {
                MessageBox.Show(Sonuc);
            }
            
        }
    }
}
