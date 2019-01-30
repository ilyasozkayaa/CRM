using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public interface IPersonelMusteriIslemleri
    {
        bool personelEkle(Personel p);
        bool personelSil(int ID);
        bool personelGüncelle(Personel p);
        List<Personel> personelleriGetir();
        Personel PersonelGetir(int ID);

        User UserGetir(string UserName);
        bool musteriEkle(Musteri p);
        bool musteriSil(int ID);
        bool musteriGüncelle(Musteri p);
        List<Musteri> musterileriGetir();
        Musteri musteriGetir(int ID);



    }
}
