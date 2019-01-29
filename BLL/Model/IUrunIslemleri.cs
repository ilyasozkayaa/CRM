using DAL.Context;
using System;
using System.Collections;
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
        List<Urun> KategoriyeGoreUrunGetir(int ktgID);
        List<Urun> TumUrunleriGetir();
        bool TekKategorideIade(int SatisDetayId, int UrunID, int Miktar);
        bool SatisiIptalEt(int SatisId);
        bool kategoriekle(Kategori k);
        bool kategoriSil(int ID);
        bool KategoriGuncelle(Kategori k);
        List<Kategori> KategoriListesi();
        Kategori KategoriGetir(int ID);
        bool StokEkle(int UrunID, int ArtisMiktari);
        ArrayList KategoriyeGoreBedenGetir(int KategoriID);
        ArrayList KategoriyeGoreKalipGetir(int KategoriID);
        ArrayList KategoriyeGoreMalzemeGetir(int KategoriID);
        bool KategoriEkleKontrol(string KategoriAdi);
        bool KategoriGuncelleKontrol(int KategoriID, string KategoriAdi);
        bool UrunEkleKontrol(string UrunAdi, string renk, string beden, string Kalıp);
        bool UrunGuncellemeKontrol(int ID, string UrunAdi, string renk, string beden, string Kalıp);

    }
}
