using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using System.Net.Mail;

namespace BLL.Model
{
    public class PromosyonPrimIslemleri : IPromosyonPrimIslemleri
    {
        CRMContext ent = new CRMContext();

        public List<Promosyon> AktifPromosyonlar(DateTime Tarih)
        {
            List<Promosyon> AktifPromosyonListesi = new List<Promosyon>();
            foreach (Promosyon p in promosyonlarıGetir())
            {
                if (p.BaslangıcTarihi.Month <= Tarih.Month && p.BaslangıcTarihi.Day <= Tarih.Day && (p.BitisTarihi.Month > Tarih.Month || p.BitisTarihi.Month == Tarih.Month && p.BitisTarihi.Day >= Tarih.Day))
                {
                    AktifPromosyonListesi.Add(p);
                }
            }
            return AktifPromosyonListesi;
        }

        public void KampanyaMesajıGönder(Kategori k, Promosyon p)
        {
            MailMessage KampanyaMesaji = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("CRMGiyim@gmail.com", "Wissen12345w");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
           
            if (k.Id == 0)
            {
                List<Musteri> MesajGonderilecekMusteriListesi = ent.Musteris.ToList();
                foreach (Musteri m in MesajGonderilecekMusteriListesi)
                {
                    KampanyaMesaji.To.Add(m.EMail);
                    KampanyaMesaji.From = new MailAddress("CRMGiyim@gmail.com");
                    KampanyaMesaji.Subject = "İndirim Fırsatını Kaçırmayın!!!";
                    KampanyaMesaji.Body = "Sayın " + m.Ad + " " + m.Soyad + " " + p.BaslangıcTarihi.ToShortDateString() + " ile " + p.BitisTarihi.ToShortDateString() + " tarihleri arasında mağazamızda " + p.PromosyonAdi + " Koleksiyonunda " + p.PromosyonOrani + " İndirim vardır, kampanyamızdan yararlanmak için belirtilen tarihler arasında mağazamıza bekleriz..Keyifli alışverişler dileriz :)";
                    istemci.Send(KampanyaMesaji);
                }
            }
            else if (p.KategoriNO > 21 && p.KategoriNO < 35)
            {
                List<Musteri> mesajgonderilecekmusteri = (from m in ent.Musteris where m.Cinsiyet == "E" select m).ToList();
                foreach (Musteri m in mesajgonderilecekmusteri)
                {
                    KampanyaMesaji.To.Add(m.EMail);
                    KampanyaMesaji.From = new MailAddress("appinventer.ilyas@gmail.com");
                    KampanyaMesaji.Subject = "İndirim Fırsatını Kaçırmayın!!!";
                    KampanyaMesaji.Body = "Sayın " + m.Ad + " " + m.Soyad + " " + p.BaslangıcTarihi.ToShortDateString() + " ile " + p.BitisTarihi.ToShortDateString() + " tarihleri arasında magazamızda " + p.PromosyonAdi + " Kategorisinde " + p.PromosyonOrani + " indirim vardır, kampanydan yararlanmak için Belirtilen tarihler arasında mağazamıza ugrayınız.Keyifli alışverişler dileriz...";
                    istemci.Send(KampanyaMesaji);
                }
            }
            else
            {
                List<Musteri> mesajgonderilecekmusteri = (from m in ent.Musteris where m.Cinsiyet == "K" select m).ToList();
                foreach (Musteri m in mesajgonderilecekmusteri)
                {
                    KampanyaMesaji.To.Add(m.EMail);
                    KampanyaMesaji.From = new MailAddress("appinventer.ilyas@gmail.com");
                    KampanyaMesaji.Subject = "İndirim Fırsatını Kaçırmayın!!!";
                    KampanyaMesaji.Body = "Sayın " + m.Ad + " " + m.Soyad + " " + p.BaslangıcTarihi.ToShortDateString() + " ile " + p.BitisTarihi.ToShortDateString() + " tarihleri arasında magazamızda " + p.PromosyonAdi + " Kategorisinde " + p.PromosyonOrani + " indirim vardır, kampanydan yararlanmak için Belirtilen tarihler arasında mağazamıza ugrayınız.Keyifli alışverişler dileriz...";
                    istemci.Send(KampanyaMesaji);
                }
            }
        }

        public bool promosyonekle(Promosyon p)
        {
            bool sonuc = false;
           
            try
            {
                
                ent.Promosyons.Add(p);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }

            return sonuc;
        }






        public bool PromosyonEkleKontrol(string PromosyonAdi)
        {

                bool sonuc = false;
               Promosyon prm = new Promosyon();
            prm = (from p in ent.Promosyons where p.PromosyonAdi == PromosyonAdi && p.Silindi == false select p).FirstOrDefault();
                if (prm != null)
                {
                    sonuc = true;
                }
                return sonuc;
            
        }

        public bool promosyonGuncelle(Promosyon p)
        {
            bool sonuc = false;
            Promosyon promosyon = (from pr in ent.Promosyons where pr.Id == p.Id select pr).FirstOrDefault();
            try
            {
                promosyon.PromosyonAdi = p.PromosyonAdi;
                promosyon.PromosyonOrani = p.PromosyonOrani;
                promosyon.BaslangıcTarihi = p.BaslangıcTarihi;
                promosyon.BitisTarihi = p.BitisTarihi;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool PromosyonGuncelleKontrol(int PromosyonID, string PromosyonAdi)
        {
            bool sonuc = false;
            Promosyon prm = new Promosyon();
            prm = (from p in ent.Promosyons where p.PromosyonAdi == PromosyonAdi && p.Id != PromosyonID select p).FirstOrDefault();
            if (prm != null)
            {
                sonuc = true;
            }
            return sonuc;
        }

        public List<Promosyon> promosyonlarıGetir()
        {
            
                List<Promosyon> promosyonlistesi = new List<Promosyon>();
                promosyonlistesi = (from m in ent.Promosyons where m.Silindi == false select m).ToList();

                return promosyonlistesi;
            
        }

        public bool promosyonSil(int ID)
        {
            bool sonuc = false;
            Promosyon SilinecekPromosyon = (from p in ent.Promosyons where p.Id == ID select p).FirstOrDefault();
            try
            {
                SilinecekPromosyon.Silindi = true;
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
