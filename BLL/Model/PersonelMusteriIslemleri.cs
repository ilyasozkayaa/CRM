using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

namespace BLL.Model
{   
    public class PersonelMusteriIslemleri : IPersonelMusteriIslemleri
    {
        CRMContext ent = new CRMContext();

        public bool musteriEkle(Musteri p)
        {
            bool sonuc = false;
            try
            {
                ent.Musteris.Add(p);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public Musteri musteriGetir(int ID)
        {

            Musteri musteri = new Musteri();
            try
            {
                musteri = (from m in ent.Musteris where m.Id == ID select m).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }


            return musteri;
        }

        public bool musteriGüncelle(Musteri p)
        {
            bool sonuc = true;
            Musteri DegisecekMusteri = (from m in ent.Musteris where m.Id == p.Id select m).FirstOrDefault();
            try
            {
                DegisecekMusteri.Ad = p.Ad;
                DegisecekMusteri.Soyad = p.Soyad;
                DegisecekMusteri.DogumTarihi = p.DogumTarihi;
                DegisecekMusteri.TCKNo = p.TCKNo;
                DegisecekMusteri.Sehir = p.Sehir;
                DegisecekMusteri.Adres = p.Adres;
                DegisecekMusteri.Telefon = p.Telefon;
                DegisecekMusteri.EMail = p.EMail;

                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;

        }

        public List<Musteri> musterileriGetir()
        {
            List<Musteri> MusteriListesi = new List<Musteri>();
            MusteriListesi = (from m in ent.Musteris where m.Silindi == false select m).ToList();

            return MusteriListesi;
        }

        public bool musteriSil(int ID)
        {
            bool sonuc = false;

            Musteri SilineceMusteri = (from m in ent.Musteris where m.Id == ID select m).FirstOrDefault();
            try
            {
                SilineceMusteri.Silindi = true;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool personelEkle(Personel p)
        {
            bool sonuc = false;
            try
            {
                ent.Personels.Add(p);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;

        }

        public Personel PersonelGetir(int ID)
        {
            Personel prsnl = new Personel();
            try
            {
                 prsnl = (from p in ent.Personels where p.Id == ID select p).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return prsnl;
        }

        public bool personelGüncelle(Personel p)
        {
            Personel prsnl = (from Personel in ent.Personels where Personel.Id == p.Id select p).FirstOrDefault();
            bool sonuc = false;
            try
            {
                prsnl.Ad = p.Ad;
                prsnl.Soyad = p.Soyad;
                prsnl.TCKNo = p.TCKNo;
                prsnl.Telefon = p.Telefon;
                prsnl.DogumTarihi = p.DogumTarihi;
                prsnl.DogumYeri = p.DogumYeri;
                prsnl.Adres = p.Adres;
                prsnl.Email = p.Email;
                prsnl.Image = p.Image;
                prsnl.Cinsiyet = p.Cinsiyet;
                prsnl.IstenCikisTarihi = p.IstenCikisTarihi;
                prsnl.MedeniHal = p.MedeniHal;
                prsnl.AskerlikDurumu = p.AskerlikDurumu;
                prsnl.EngelDurumu = p.EngelDurumu;
                prsnl.EgitimDurumu = p.EgitimDurumu;
                prsnl.UserId = p.UserId;

                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
            return sonuc;
        }

        public List<Personel> personelleriGetir()
        {
            List<Personel> PersonelListesi = new List<Personel>();
            PersonelListesi = (from p in ent.Personels where p.Silindi==false select p).ToList();

            return PersonelListesi;
        }

        public bool personelSil(int ID)
        {
            bool sonuc = false;
            Personel SilinecekPersonel = (from p in ent.Personels where p.Id == ID select p).FirstOrDefault();
            try
            {
                SilinecekPersonel.Silindi = true;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
            
        }
        public int UsersIdyeGorePersoneliGetirme(int ID)// personel tablosundaki UsersId kolonunagore arama yapıpo satırı getirdım ve return gelen satırdalkı  ıd yı aldım.
        {
            Personel prsnl = new Personel();
            prsnl = (from p in ent.Personels where p.UserId == ID select p).FirstOrDefault();
            return prsnl.Id;
        }
        public User UserGetir(string UserName)
        {
            User userg = new User();
            try
            {
                userg = (from p in ent.Users where p.KullaniciAdi == UserName select p).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return userg;
        }
    }
}
