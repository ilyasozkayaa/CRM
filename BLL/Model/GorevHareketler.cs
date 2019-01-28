using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class GorevHareketler:IGorevHareketIer
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

        
    }

}
