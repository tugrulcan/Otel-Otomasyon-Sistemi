using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otel_Otomasyon_Projesi_YZM3101.Business_Layer
{
    class RezervasyonIslem
    {
        private static DBOtelEntities db = new DBOtelEntities();

        public static string RezervasyonYap(MusteriView mus,KartView kart,RezervasyonView rezerve)
        {
            try
            {
                using (DBOtelEntities db = new DBOtelEntities())
                {
                    tblKrediKartlari kredi = new tblKrediKartlari();
                    kredi.kartNumarasi = kart.KartNumarasi;
                    kredi.kartUzerindekiAd = kart.KartUzerindekiAd;
                    kredi.sonKullanımTarihi = kart.SonKullanimTarihi;
                    kredi.guvenlikKodu = kart.GuvenlikKodu;
                    db.tblKrediKartlari.Add(kredi);
                    db.SaveChanges();

                    tblMusteriler musteri = new tblMusteriler();
                    musteri.musteriAd = mus.MusteriAd;
                    musteri.musteriSoyad = mus.MusteriSoyad;
                    musteri.musteriEposta = mus.MusteriEPosta;
                    musteri.krediKartiID = (from i in db.tblKrediKartlari
                                            where i.kartNumarasi == kart.KartNumarasi
                                            select i.krediKartiID).SingleOrDefault();
                    db.tblMusteriler.Add(musteri);
                    db.SaveChanges();

                    tblRezervasyon rezerv = new tblRezervasyon();
                    rezerv.baslangicTarihi = rezerve.BaslangicTarihi;
                    rezerv.bitisTarihi = rezerve.BitisTarihi;
                    rezerv.musteriID = (from i in db.tblMusteriler
                                        where i.musteriEposta == mus.MusteriEPosta
                                        select i.musteriID).SingleOrDefault();
                    rezerv.rezervasyonOlusturmaTarihi = rezerve.RezervasyonOlusturmaTarihi;
                    rezerv.tabanFiyatID = (from i in db.tblTabanFiyatlar
                                           where i.tanımlandigiTarih > rezerv.baslangicTarihi && i.sonGecerlilikTarihi < rezerv.bitisTarihi
                                           select i.tabanFiyatID).SingleOrDefault();

                    db.tblRezervasyon.Add(rezerv);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static List<string> RezerveTipleri()
        {
            try
            {
                using(DBOtelEntities db = new DBOtelEntities())
                {
                    List<string> liste = new List<string>();
                    var tip = (from i in db.tblRezervasyonTipleri
                               select i.rezervasyonTipi).ToList();
                    foreach(var i in tip)
                    {
                        liste.Add(i);
                    }
                    return liste;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
        public static void RezervasyonIptal(tblRezervasyon r)
        {
            r.rezervasyonDurumID = 0;
            tblIptalEdilenRezervasyonlar rip = new tblIptalEdilenRezervasyonlar();
            rip.rezervasyonID = r.rezervasyonID;
            rip.iptalEdilmeTarihi = DateTime.Today;
            db.SaveChanges();
            decimal? cezaUcreti = CezaHesapla(r, rip);
        }

        public static decimal? CezaHesapla(tblRezervasyon r, tblIptalEdilenRezervasyonlar rip)
        {
            if (r.rezervasyonTipID == 2 || r.rezervasyonTipID == 3)
            {
                if (Convert.ToInt32(DateTime.Today) - Convert.ToInt32(rip.iptalEdilmeTarihi) < 3)
                    return r.ucret *= 80 / 100;
            }
            return r.ucret;
        }

        public static void RezervasyonBitisi(tblRezervasyon r)
        {
            if (r.bitisTarihi == DateTime.Today)
            {
                var v = (from R in db.tblRezervasyon join O in db.tblOdalar on R.OdaID equals O.OdaID where R.rezervasyonID == r.rezervasyonID select O).SingleOrDefault();
                v.OdaDurumKodu = 0;
            }
            db.SaveChanges();
        }
    }
}
