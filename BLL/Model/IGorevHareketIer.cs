using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public interface IGorevHareketIer
    {
        bool GorevEkle(Gorev u);
        bool GorevDetayEkle(List<GorevDetay> u);
        bool GorevKayıtEkle(List<GorevKayit> u);

    }
}
