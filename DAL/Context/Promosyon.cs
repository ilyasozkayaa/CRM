using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    [Table("Promosyonlar")]
   public class Promosyon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PromosyonAdi { get; set; }
        [Required]
        public decimal  PromosyonOrani { get; set; }
        [Required]
        public DateTime BaslangıcTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        public int KategoriNO { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        public virtual List<SatisDetay> SatisDetays { get; set; }
    }
}
