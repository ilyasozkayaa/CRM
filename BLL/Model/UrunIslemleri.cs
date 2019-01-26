using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

namespace BLL.Model
{
    public class UrunIslemleri : IUrunIslemleri
    {
        CRMContext ent = new CRMContext();

        public bool KategoriEkle(Kategori k)
        {

            bool sonuc = false;
            try
            {
                ent.Kategoris.Add(k);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }


            return sonuc;
        }

        public bool KategoriGuncelle(Kategori k)
        {
            bool sonuc = false;
            Kategori DegisecekKtg = (from ktg in ent.Kategoris where ktg.Id == k.Id select ktg).FirstOrDefault();
            try
            {
                DegisecekKtg.KategoriAdi = k.KategoriAdi;
                DegisecekKtg.Aciklama = k.Aciklama;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public List<Kategori> kategorileriGetir()
        {
            List<Kategori> ktgListesi = new List<Kategori>();
            ktgListesi = (from k in ent.Kategoris where k.Silindi == false select k).ToList();
            return ktgListesi;
        }

        public bool KategoriSil(int ID)
        {
            bool sonuc = false;
            Kategori silicenekKtg = (from k in ent.Kategoris where k.Id == ID select k).FirstOrDefault();
            try
            {
                silicenekKtg.Silindi = true;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public List<Urun> KategoriyeGoreUrunGetir(int ktgID)
        {
            List<Urun> KategoriyeGoreUrunListesi = new List<Urun>();
            KategoriyeGoreUrunListesi = (from u in ent.Uruns where u.KategoriId == ktgID select u).ToList();

            return KategoriyeGoreUrunListesi;
        }

        public List<SatisDetay> SatisDetayGetir(int ID)
        {
            List<SatisDetay> sdListesi = new List<SatisDetay>();
            try
            {
                sdListesi=(from sd in ent.SatisDetays where sd.SatısId == ID select sd).ToList();

            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            
            return sdListesi;
        }

        public List<SatisDetay> SatisDetaylarinHepsiniGetir()
        {
            List<SatisDetay> satisDetayListesi = new List<SatisDetay>();
            satisDetayListesi = ent.SatisDetays.ToList();
            return satisDetayListesi;
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


        public bool TekKategorideIade(int SatisDetayId, int UrunID, int Miktar)
        {
            bool sonuc = true;
            SatisDetay sd = (from s in ent.SatisDetays where s.Id == SatisDetayId select s).FirstOrDefault();
            Urun IadeEdilenUrun = (from u in ent.Uruns where u.Id == sd.UrunId select u).FirstOrDefault();
            try
            {
                if(sd.Miktar==Miktar)
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
    }

       
    
}
