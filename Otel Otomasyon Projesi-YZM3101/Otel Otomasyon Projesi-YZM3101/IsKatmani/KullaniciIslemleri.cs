using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Otel_Otomasyon_Projesi_YZM3101.IsKatmani
{
    public class KullaniciIslemleri
    {
        public static string KullaniciEkle(string KAd,string Sifre,int Type)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    tblKullanicilar K = new tblKullanicilar();
                    K.kullaniciID = KAd;
                    K.kullaniciSifre = Sifre;
                    K.kullaniciTipID = Type;

                    db.tblKullanicilar.Add(K);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return e.Message;
            }
        }

        public static string Login(string KAd,string Sifre)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    var kullanici = (from k in db.tblKullanicilar
                                     where k.kullaniciID == KAd && k.kullaniciSifre == Sifre
                                     select k).SingleOrDefault();

                    if(kullanici != null)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }

                }
            }catch(Exception e)
            {
                return e.Message;
            }
        }
        public static DataTable BeklenenDolulukRaporu ()
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    //var queryy = db.Database.SqlQuery(@"Select RT.rezervasyonTipi,COUNT(O.OdaID) As 'Oda Sayısı',R.baslangicTarihi,R.bitisTarihi,RD.durumAciklama
                    //                       From tblRezervasyon R INNER JOIN tblRezervasyonTipleri RT ON r.rezervasyonTipID = RT.rezervasyonTipi
                    //                                             INNER JOIN tblRezervasyonDurum RD ON R.rezervasyonDurumID = RD.rezervasyonDurumID
                    //                                             INNER JOIN tblOdalar O ON R.OdaID = O.OdaID
                    //                       Where DATENAME(YEAR, GETDATE() + 30) = DATENAME(YEAR, R.baslangicTarihi) AND
                    //                             DATENAME(MONTH, GETDATE() + 30) = DATENAME(MONTH, R.baslangicTarihi) AND
                    //                             DATENAME(DAY, GETDATE() + 30) = DATENAME(DAY, R.baslangicTarihi)
                    //                       Group by RT.rezervasyonTipi, R.baslangicTarihi, R.bitisTarihi, RD.durumAciklama");
                    var rap = (from R in db.tblRezervasyon
                               join RT in db.tblRezervasyonTipleri on R.rezervasyonTipID equals RT.rezervasyonTipID
                               join RD in db.tblRezervasyonDurum on R.rezervasyonDurumID equals RD.rezervasyonDurumID
                               join O in db.tblOdalar on R.OdaID equals O.OdaID
                               where DateTime.Now.AddDays(30).Year >= R.baslangicTarihi.Year &&
                                      DateTime.Now.AddDays(30).Month >= R.baslangicTarihi.Month &&
                                      DateTime.Now.AddDays(30).Day >= R.baslangicTarihi.Day
                               select new
                               {
                                   RezervasyonTipi = RT.rezervasyonTipi,
                                   BaslangicTarihi = R.baslangicTarihi,
                                   BitisTarihi = R.bitisTarihi,
                                   Durum = RD.durumAciklama
                               });//.GroupBy(a => a.RezervasyonTipi);
                    DataTable dt = new DataTable();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    foreach (var item in rap)
                        dt.Rows.Add(item.RezervasyonTipi, item.BaslangicTarihi, item.BitisTarihi, item.Durum);
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null ;
            }
        }
        public static string Fatura(int rezervasyonID)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    //var queryy = db.Database.SqlQuery(@"Select RT.rezervasyonTipi,COUNT(O.OdaID) As 'Oda Sayısı',R.baslangicTarihi,R.bitisTarihi,RD.durumAciklama
                    //                       From tblRezervasyon R INNER JOIN tblRezervasyonTipleri RT ON r.rezervasyonTipID = RT.rezervasyonTipi
                    //                                             INNER JOIN tblRezervasyonDurum RD ON R.rezervasyonDurumID = RD.rezervasyonDurumID
                    //                                             INNER JOIN tblOdalar O ON R.OdaID = O.OdaID
                    //                       Where DATENAME(YEAR, GETDATE() + 30) = DATENAME(YEAR, R.baslangicTarihi) AND
                    //                             DATENAME(MONTH, GETDATE() + 30) = DATENAME(MONTH, R.baslangicTarihi) AND
                    //                             DATENAME(DAY, GETDATE() + 30) = DATENAME(DAY, R.baslangicTarihi)
                    //                       Group by RT.rezervasyonTipi, R.baslangicTarihi, R.bitisTarihi, RD.durumAciklama");
                    var f = (from M in db.tblMusteriler
                             join R in db.tblRezervasyon on M.musteriID equals R.musteriID
                             join O in db.tblOdalar on R.OdaID equals O.OdaID
                             join RT in db.tblRezervasyonTipleri on R.rezervasyonTipID equals RT.rezervasyonTipID
                             where R.rezervasyonID == rezervasyonID 
                             select new
                             {
                                 MusteriAdi = M.musteriAd,
                                 MusteriSoyadi = M.musteriSoyad,
                                 OdaNumarasi = O.OdaID,
                                 GelisTarihi = R.baslangicTarihi,
                                 GidisTarihi = R.bitisTarihi,
                                 GeceSayisi = Convert.ToInt32((R.bitisTarihi - R.baslangicTarihi).Days),
                                 RezervasyonTipi = RT.rezervasyonTipi,
                                 Ucret = R.ucret,
                                 OdemeTarihi = DateTime.Now
                             });
                    string Fatura = "";
                    foreach (var item in f)
                        Fatura = item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.RezervasyonTipi + " " + item.OdaNumarasi + " " + item.GelisTarihi + " " + item.GidisTarihi+" " + item.Ucret.ToString()+" "+ "\n";
                    return Fatura;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static DataTable GunlukGelenlerRaporu()
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    //var queryy = db.Database.SqlQuery(@"Select RT.rezervasyonTipi,COUNT(O.OdaID) As 'Oda Sayısı',R.baslangicTarihi,R.bitisTarihi,RD.durumAciklama
                    //                       From tblRezervasyon R INNER JOIN tblRezervasyonTipleri RT ON r.rezervasyonTipID = RT.rezervasyonTipi
                    //                                             INNER JOIN tblRezervasyonDurum RD ON R.rezervasyonDurumID = RD.rezervasyonDurumID
                    //                                             INNER JOIN tblOdalar O ON R.OdaID = O.OdaID
                    //                       Where DATENAME(YEAR, GETDATE() + 30) = DATENAME(YEAR, R.baslangicTarihi) AND
                    //                             DATENAME(MONTH, GETDATE() + 30) = DATENAME(MONTH, R.baslangicTarihi) AND
                    //                             DATENAME(DAY, GETDATE() + 30) = DATENAME(DAY, R.baslangicTarihi)
                    //                       Group by RT.rezervasyonTipi, R.baslangicTarihi, R.bitisTarihi, RD.durumAciklama");
                    var gRapor = (from R in db.tblRezervasyon
                                  join M in db.tblMusteriler on R.musteriID equals M.musteriID
                                  join RT in db.tblRezervasyonTipleri on R.rezervasyonTipID equals RT.rezervasyonTipID
                                  where DateTime.Now.Day == R.baslangicTarihi.Day &&
                                        DateTime.Now.Month == R.baslangicTarihi.Month &&
                                        DateTime.Now.Year == R.baslangicTarihi.Year
                                  select new
                                  {
                                      MusteriAdi = M.musteriAd,
                                      MusteriSoyad = M.musteriSoyad,
                                      RezervasyonTip = RT.rezervasyonTipi,
                                      OdaNo = R.OdaID,
                                      AyrilisTarihi = R.bitisTarihi
                                  }).OrderBy(X=> X.MusteriAdi);
                    string rapor = "";
                    DataTable dt = new DataTable();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    dt.Columns.Add();
                    foreach (var item in gRapor)
                        dt.Rows.Add(item.MusteriAdi,item.MusteriSoyad,item.RezervasyonTip,item.OdaNo,item.AyrilisTarihi);
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null; 
            }
        }


    }
}
