using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon_Projesi_YZM3101.Business_Layer
{
    public class OdaIslemleri
    {
        public static List<int> MusterileriGetir()
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    List<int> liste = new List<int>();
                    var musteriId = (from i in db.tblRezervasyon
                                     where i.OdaID == null && i.baslangicTarihi.Date == DateTime.Now.Date
                                     select i.musteriID).ToList();
                    foreach(var i in musteriId)
                    {
                        liste.Add(i);
                    }
                    return liste;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public static List<string> OdalariGetir()
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    List<string> liste = new List<string>();
                    var odalar = (from i in db.tblOdalar
                                  where i.OdaDurumKodu == 0
                                  select i.OdaID).ToList();
                    foreach(var i in odalar)
                    {
                        liste.Add(i.ToString());
                    }
                    return liste;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static string OdaVer(int musteriId,int OdaId)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    var musteri = (from i in db.tblRezervasyon
                                   where i.musteriID == musteriId
                                   select i).SingleOrDefault();

                    musteri.OdaID = OdaId;
                    db.SaveChanges();

                    var oda = (from i in db.tblOdalar
                               where i.OdaID == OdaId
                               select i).SingleOrDefault();
                    oda.OdaDurumKodu = 1;
                    db.SaveChanges();
                    return "yes";                    
                }
            }catch(Exception e)
            {
                return "no";
            }
        }
    }
}
