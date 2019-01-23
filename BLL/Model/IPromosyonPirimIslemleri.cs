using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public interface IPromosyonPrimIslemleri
    {
        bool promosyonEkle(Promosyon p);
        bool promosyonSil(int ID);
        bool promosyonGuncelle(Promosyon p);
    }
}
