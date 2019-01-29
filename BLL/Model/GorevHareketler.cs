using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class GorevHareketler : IGorevHareketIer
    {
        CRMContext ent = new CRMContext();
        public bool GorevEkle(Gorev u)
        {
            bool sonuc = false;
            try
            {
                ent.Gorevs.Add(u);
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return sonuc;
        }
        public bool GorevDetayEkle(List<GorevDetay> u)
        {
            bool sonuc = false;
            try
            {
                foreach (GorevDetay item in u)
                {
                    ent.GorevDetays.Add(item);
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
        public bool GorevKayıtEkle(List<GorevKayit> u)
        {
            bool sonuc = false;
            try
            {
                foreach (GorevKayit item in u)
                {
                    ent.GorevKayits.Add(item);
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
        public int UsersIdByGorevId(int ID)
        {
            GorevKayit grvkyt = new GorevKayit();

            try
            {
                grvkyt = (from g in ent.GorevKayits where g.PersonelId == ID select g).FirstOrDefault();

            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return grvkyt.GorevId;
        }
        public Gorev GorevGetir(int ID)
        {
            Gorev grv = new Gorev();
            try
            {
                grv = (from g in ent.Gorevs where g.Id == ID select g).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return grv;
        }
        public GorevDetay GorevHareketGetir(int ID)
        {
            GorevDetay grvh = new GorevDetay();
            try
            {
                grvh = (from g in ent.GorevDetays where g.Id == ID select g).FirstOrDefault();
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            return grvh;
        }
        //public List<GorevKayit> KayıtListGetir(int PersonelId)
        //{
        //    List<GorevKayit> PersonelListesi = new List<GorevKayit>();

        //    Gorevlg=(from g in ent.GorevKayits where g.PersonelId == PersonelId select g).ToList();

        //    return Gorevlg
          
        //}

    
    
    }

}
