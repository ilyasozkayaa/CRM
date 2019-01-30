using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;

namespace BLL.Model
{
    public class UrunIslemleri : IUrunIslemleri
    {
        CRMContext ent = new CRMContext();

        public bool kategoriekle(Kategori k)
        {
            bool sonuc = false;
            Kategori Yeniktg = new Kategori();
            try
            {
                Yeniktg.KategoriAdi = k.KategoriAdi;
                Yeniktg.Aciklama = k.Aciklama;
                Yeniktg.Silindi = false;
                ent.Kategoris.Add(Yeniktg);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }

            return sonuc;
        }

        public bool KategoriEkleKontrol(string KategoriAdi)
        {
            bool sonuc = false;
            Kategori ktg = (from k in ent.Kategoris where k.KategoriAdi == KategoriAdi select k).FirstOrDefault();
            if (ktg != null)
            {
                sonuc = true;
            }
            return sonuc;
        }

        public Kategori KategoriGetir(int ID)
        {
            Kategori ktg = new Kategori();
            try
            {
                ktg = (from k in ent.Kategoris where k.Id == ID select k).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }


            return ktg;
        }

        public bool KategoriGuncelle(Kategori k)
        {
            Kategori Degisecekktg = (from ktg in ent.Kategoris where ktg.Id == k.Id select ktg).FirstOrDefault();
            bool sonuc = false;
            try
            {
                Degisecekktg.KategoriAdi = k.KategoriAdi;
                Degisecekktg.Aciklama = k.Aciklama;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool KategoriGuncelleKontrol(int KategoriID, string KategoriAdi)
        {
            bool sonuc = false;
            Kategori ktg = (from k in ent.Kategoris where k.KategoriAdi == KategoriAdi && k.Id != KategoriID select k).FirstOrDefault();
            if (ktg != null)
            {
                sonuc = true;
            }
            return sonuc;
        }

        public List<Kategori> KategoriListesi()
        {
            List<Kategori> KtgList = new List<Kategori>();
            KtgList = (from ktg in ent.Kategoris where ktg.Silindi == false select ktg).ToList();

            return KtgList;
        }

        public bool kategoriSil(int ID)
        {
            bool sonuc = true;
            Kategori SilinecekKtg = (from ktg in ent.Kategoris where ktg.Id == ID select ktg).FirstOrDefault();
            try
            {
                SilinecekKtg.Silindi = true;
                ent.SaveChanges();

            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public ArrayList KategoriyeGoreBedenGetir(int KategoriID)
        {
            string beden = "";
            ArrayList KategoriyeGoreBedenListesi = new ArrayList();
            foreach (Urun item in TumUrunleriGetir())
            {
                beden = item.Beden;
                if (item.KategoriId == KategoriID)
                {
                    if (!KategoriyeGoreBedenListesi.Contains(beden))
                    {
                        KategoriyeGoreBedenListesi.Add(item.Beden);
                    }
                }
            }




            return KategoriyeGoreBedenListesi;
        }

        public ArrayList KategoriyeGoreKalipGetir(int KategoriID)
        {
            string kalip = "";
            ArrayList KategoriyeGoreKalipListesi = new ArrayList();
            foreach (Urun item in TumUrunleriGetir())
            {
                kalip = item.Kalip;
                if (item.KategoriId == KategoriID)
                {
                    if (!KategoriyeGoreKalipListesi.Contains(kalip))
                    {
                        KategoriyeGoreKalipListesi.Add(item.Kalip);
                    }
                }
            }




            return KategoriyeGoreKalipListesi;
        }

        public ArrayList KategoriyeGoreMalzemeGetir(int KategoriID)
        {
            string Malzeme = "";
            ArrayList KategoriyeGoreMalzemeListesi = new ArrayList();
            foreach (Urun item in TumUrunleriGetir())
            {
                Malzeme = item.Beden;
                if (item.KategoriId == KategoriID)
                {
                    if (!KategoriyeGoreMalzemeListesi.Contains(Malzeme))
                    {
                        KategoriyeGoreMalzemeListesi.Add(item.Malzemesi);
                    }
                }
            }




            return KategoriyeGoreMalzemeListesi;
        }

        public List<Urun> KategoriyeGoreUrunGetir(int ktgID)
        {
            List<Urun> KategoriyeGoreUrunListesi = new List<Urun>();
            KategoriyeGoreUrunListesi = (from u in ent.Uruns where u.KategoriId == ktgID select u).ToList();

            return KategoriyeGoreUrunListesi;
        }

        public bool SatisDetayEkle(SatisDetay sd)
        {
            bool sonuc = false;
            try
            {
                ent.SatisDetays.Add(sd);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool SatisEkle(Satis s)
        {
            bool sonuc = false;
            try
            {
                ent.satis.Add(s);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool SatisiIptalEt(int SatisId)
        {
            bool sonuc = false;
            List<SatisDetay> IptalEdilecekSatis = (from sd in ent.SatisDetays where sd.SatısId == SatisId select sd).ToList();
            foreach (SatisDetay item in IptalEdilecekSatis)
            {
                Urun IadeEdilenUrun = (from u in ent.Uruns where u.Id == item.UrunId select u).FirstOrDefault();
                try
                {
                    item.Silindi = true;
                    IadeEdilenUrun.StokMiktarı += item.Miktar;
                    ent.SaveChanges();
                }
                catch (Exception ex)
                {

                    string message = ex.Message;
                }           
            }


            return sonuc;
        }

        public List<SatisDetay> SatısDetaylariniGetir(int ID)
        {
            List<SatisDetay> sd = new List<SatisDetay>();
            sd = (from sdetay in ent.SatisDetays where sdetay.SatısId == ID && sdetay.Silindi==false select sdetay).ToList();
            return sd;
        }

        public int SonSatisIDBul()
        {
            int SonSatiısID = ent.satis.Max(s => s.Id); ;
            return SonSatiısID;
        }

        public bool StokAzalt(int UrunID, int Miktar)
        {
            bool sonuc = false;
            Urun EklenecekUrun = (from u in ent.Uruns where u.Id == UrunID select u).FirstOrDefault();
            UrunStokHareket SHareket = new UrunStokHareket();
            try
            {
                EklenecekUrun.StokMiktarı -= Miktar;

                SHareket.IslemTürü = "Satılan";
                SHareket.UrunId = UrunID;
                SHareket.Miktar = Miktar;
                SHareket.IslemTarihi = DateTime.Now;
                ent.UrunStokHarekets.Add(SHareket);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ec)
            {

                string message = ec.Message;
            }
            return sonuc;
        }

        public bool StokEkle(int UrunID, int ArtisMiktari)
        {
            bool sonuc = false;
            Urun EklenecekUrun = (from u in ent.Uruns where u.Id == UrunID select u).FirstOrDefault();
            UrunStokHareket SHareket = new UrunStokHareket();
            try
            {
                EklenecekUrun.StokMiktarı += ArtisMiktari;

                SHareket.IslemTürü = "Alınan";
                SHareket.UrunId = UrunID;
                SHareket.Miktar = ArtisMiktari;
                SHareket.IslemTarihi = DateTime.Now;
                ent.UrunStokHarekets.Add(SHareket);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ec)
            {

                string message = ec.Message;
            }
            return sonuc;
        }

        public bool TekKategorideIade(int SatisDetayId, int UrunID, int Miktar)
        {
            bool sonuc = true;
            SatisDetay sd = (from s in ent.SatisDetays where s.Id == SatisDetayId select s).FirstOrDefault();
            Urun IadeEdilenUrun = (from u in ent.Uruns where u.Id == sd.UrunId select u).FirstOrDefault();
            try
            {
                if (sd.Miktar == Miktar)
                {
                    sd.Silindi = true;
                    IadeEdilenUrun.StokMiktarı += sd.Miktar;
                    ent.SaveChanges();
                }
                else
                {
                    sd.Miktar -= Miktar;
                    IadeEdilenUrun.StokMiktarı += Miktar;
                    ent.SaveChanges();
                }
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;

        }

        public List<Urun> TumUrunleriGetir()
        {
            List<Urun> Urunler = new List<Urun>();
            Urunler = (from u in ent.Uruns where u.Silindi == false select u).ToList();

            return Urunler;
        }

        public Urun urunBul(int ID)
        {
            Urun urun = new Urun();
            try
            {
                urun = (from u in ent.Uruns where u.Id == ID select u).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return urun;
        }

        public Urun UrunBul(string UrunAdi)
        {
            Urun urun = new Urun();
            try
            {
                urun = (from u in ent.Uruns where u.UrunAdi == UrunAdi select u).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return urun;
        }

        public bool urunEkle(Urun u)
        {

            bool sonuc = false;
            try
            {
                ent.Uruns.Add(u);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool UrunEkleKontrol(string UrunAdi, string renk, string beden, string Kalıp)
        {
            Urun u = new Urun();
            bool varmi = false;
            try
            {
                u = (from urun in ent.Uruns where urun.UrunAdi == UrunAdi && urun.Renk == renk && urun.Beden == beden && urun.Kalip == Kalıp select urun).FirstOrDefault();
                if (u != null)
                {
                    varmi = true;
                }
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return varmi;
        }



        public bool urunGuncelle(Urun u)
        {
            bool sonuc = true;
            Urun DegisecekUrun = (from d in ent.Uruns where d.Id == u.Id select d).FirstOrDefault();
            try
            {
                DegisecekUrun.KategoriId = u.KategoriId;
                DegisecekUrun.UrunAdi = u.UrunAdi;
                DegisecekUrun.Kalip = u.Kalip;
                DegisecekUrun.Beden = u.Beden;
                DegisecekUrun.Malzemesi = u.Malzemesi;
                DegisecekUrun.ÜretimYeri = u.ÜretimYeri;
                DegisecekUrun.StokMiktarı = u.StokMiktarı;
                DegisecekUrun.KritikEsik = u.KritikEsik;
                DegisecekUrun.AlisFiyat = u.AlisFiyat;
                DegisecekUrun.SatisFiyat = u.SatisFiyat;
                DegisecekUrun.Renk = u.Renk;

                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool UrunGuncellemeKontrol(int ID, string UrunAdi, string renk, string beden, string Kalıp)
        {
            Urun u = new Urun();
            bool varmi = false;
            try
            {
                u = (from urun in ent.Uruns where urun.UrunAdi == UrunAdi && urun.Renk == renk && urun.Beden == beden && urun.Kalip == Kalıp && urun.Id!=ID select urun).FirstOrDefault();
                if (u != null)
                {
                    varmi = true;
                }
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return varmi;
        }

        public bool UrunIadeHareket(UrunIade Uiade)
        {
            bool sonuc = false;
            try
            {
                ent.UrunIades.Add(Uiade);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool urunSil(int ID)
        {
            bool sonuc = true;
            Urun DegisecekUrun = (from u in ent.Uruns where u.Id == ID select u).FirstOrDefault();
            try
            {
                DegisecekUrun.Silindi = true;

                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool UrunStokGuncelle(int ID, int SatisMiktari)
        {
            bool sonuc = false;
            Urun DegisecekUrun = (from d in ent.Uruns where d.Id == ID select d).FirstOrDefault();
            try
            {
                if (DegisecekUrun.StokMiktarı < SatisMiktari)
                {
                    MessageBox.Show("Satılmak İstenilen Miktarda Ürün Depoda Mevcut Değil!!!");
                }
                else
                {
                    DegisecekUrun.StokMiktarı -= SatisMiktari;

                    ent.SaveChanges();
                }

                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }
    }

       
    
}
