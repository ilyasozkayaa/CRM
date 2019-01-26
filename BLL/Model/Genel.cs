using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;

namespace BLL.Model
{
    public class Genel : IGenel
    {
        CRMContext ent = new CRMContext();
        public void FormAcikmi()
        {
            throw new NotImplementedException();
        }

        public int giris(string KullaniciAdi, string parola)
        {

            int ID=0;
            List<User> plistesi = new List<User>();
            plistesi = ent.Users.ToList();
            foreach (User u in plistesi)
            {
                if (u.KullaniciAdi == KullaniciAdi && u.Parola == parola)
                {
                    ID = u.Id;
                }
            }
            return ID;
        }

        public bool ParolaSifirla(int prsnlID, string YeniParola)
        {
            User ParolasiDegisecek = new User();
            bool sonuc = false;
            try
            {
                ParolasiDegisecek = (from u in ent.Users where u.Id == prsnlID select u).FirstOrDefault();
                ParolasiDegisecek.Parola = YeniParola;
                ent.SaveChanges();
                sonuc = true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
            }
            

            return sonuc;
        }

        public void Temizle()
        {
            throw new NotImplementedException();
        }

    }
}
