using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon_Projesi_YZM3101.Business_Layer
{
    class KullaniciIslemler
    {
        public static string KullaniciEkle(string KAd, string Sifre, int Type)
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
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string Login(string KAd, string Sifre)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    KullaniciId kI = new KullaniciId();
                    var kullanici = (from k in db.tblKullanicilar
                                     where k.kullaniciID == KAd && k.kullaniciSifre == Sifre
                                     select k).SingleOrDefault();

                    if (kullanici != null)
                    {
                        kI.setKullanici(kullanici.kullaniciID);
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }

                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static decimal? BeklenenOdaGelirRaporu()
        {
            try
            {
                using (DBOtelEntities   db = new DBOtelEntities())
                {
                    decimal? toplam = 0;
                    var veriler = (from r in db.tblRezervasyon
                                   where DateTime.Now.AddDays(30).Year >= r.baslangicTarihi.Year &&
                                   DateTime.Now.AddDays(30).Month >= r.baslangicTarihi.Month &&
                                   DateTime.Now.AddDays(30).Day >= r.baslangicTarihi.Day
                                   select r.ucret).ToList();

                    foreach (var i in veriler)
                    {
                        toplam += i;
                    }

                    return toplam;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static int BeklenenOdaGelirRaporuCount()
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    var veriler = (from r in db.tblRezervasyon
                                   where DateTime.Now.AddDays(30).Year >= r.baslangicTarihi.Year &&
                                   DateTime.Now.AddDays(30).Month >= r.baslangicTarihi.Month &&
                                   DateTime.Now.AddDays(30).Day >= r.baslangicTarihi.Day
                                   select r.ucret).ToList();
                                        
                    return veriler.Count;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static string BeklenenDolulukRaporu()
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
                    var r = (from R in db.tblRezervasyon
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
                             }).GroupBy(a => a.RezervasyonTipi).ToList();
                    string Rapor = "";
                    foreach (var item in r)
                        Rapor += item + "\n";
                    return Rapor;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string Fatura()
        {
            try
            {
                TimeSpan ts;
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
                        Fatura += item + "\n";
                    return Fatura;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
