using System;
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
        public bool promosyonEkle(Promosyon p)
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

        public bool promosyonGuncelle(Promosyon p)
        {
            bool sonuc = false;
            Promosyon promosyon = (from pr in ent.Promosyons where pr.Id == p.Id select pr).FirstOrDefault();
            try
            {
                promosyon.PromosyonAdi = p.PromosyonAdi;
                promosyon.PromosyonOrani = p.PromosyonOrani;

                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }

        public bool promosyonSil(int ID)
        {
            bool sonuc = true;
            Promosyon SilinecekPromosyon = (from p in ent.Promosyons where p.Id == ID select p).FirstOrDefault();
            try
            {
                SilinecekPromosyon.Silindi = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }
    }
}
