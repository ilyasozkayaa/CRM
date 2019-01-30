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
        bool promosyonEkle(Promosyon p, int PromosyonOrani);
        bool promosyonSil(int ID);
        bool promosyonGuncelle(Promosyon p);
        bool PromosyonEkleKontrol(string PromosyonAdi);
        bool PromosyonGuncelleKontrol(int PromosyonID, string PromosyonAdi);
        List<Promosyon> promosyonlarıGetir();
        List<Promosyon> AktifPromosyonlar(DateTime Tarih);
    }
}
