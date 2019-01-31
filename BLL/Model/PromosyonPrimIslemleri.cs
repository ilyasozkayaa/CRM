﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

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
