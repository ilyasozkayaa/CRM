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
        bool gorevEkle(Gorev g);

    }
}
