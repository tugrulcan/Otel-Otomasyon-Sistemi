using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon_Projesi_YZM3101.Business_Layer
{
    public class KullaniciId
    {
        private static string Kullanici;
        public string getKullanici()
        {
            return Kullanici;
        }
        public void setKullanici(string kullanici)
        {
            Kullanici = kullanici;
        }
    }
}
