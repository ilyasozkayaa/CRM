using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public interface IGenel
    {
        int giris(string KullaniciAdi, string parola);
        bool ParolaSifirla(string prsnlID,string YeniParola);
        void Temizle();
        void FormAcikmi();
    }
}
