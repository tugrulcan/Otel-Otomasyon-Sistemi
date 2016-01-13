using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon_Projesi_YZM3101.Business_Layer
{
    class RaporIslemleri
    {
        //public static string TesvikRaporuOlustur()
        //{
        //    try
        //    {
        //        using (DBOtelEntities db = new DBOtelEntities())
        //        {
        //            var r = (from R in db.tblRezervasyon
        //                     join RT in db.tblRezervasyonTipleri on R.rezervasyonTipID equals RT.rezervasyonTipID
        //                     join TF in db.tblTabanFiyatlar on R.tabanFiyatID equals TF.tabanFiyatID
        //                     where DateTime.Now.AddDays(30).Year >= R.baslangicTarihi.Year &&
        //                            DateTime.Now.AddDays(30).Month >= R.baslangicTarihi.Month &&
        //                            DateTime.Now.AddDays(30).Day >= R.baslangicTarihi.Day &&
        //                            RT.rezervasyonTipID == 3
        //                     select new
        //                     {
        //                         Ucret = TF.tabanFiyat = TF.tabanFiyat - TF.tabanFiyat * 20 / 100,
        //                         Zarar = TF.tabanFiyat - Ucret,
        //                         TarihYil = DateTime.Now.Year,
        //                         TarihAy = DateTime.Now.Month,
        //                         TarihGun = DateTime.Now.Day
        //                     });
        //            string Rapor = "";
        //            foreach (var item in r)
        //                Rapor += item + "\n";
        //            return Rapor;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return e.Message;
        //    }
        //} 
    }
}
