using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public interface IUrunIslemleri
    {
        bool urunEkle(Urun u);
        bool urunGuncelle(Urun u);
        bool urunSil(int ID);
        Urun urunBul(int ID);
        Urun UrunBul(string UrunAdi);
        bool TekKategorideIade(int SatisDetayId, int UrunID, int Miktar);
        bool SatisiIptalEt(int SatisId);

    }
}
