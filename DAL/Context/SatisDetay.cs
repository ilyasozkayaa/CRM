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
    [Table("Satış Detayları")]
   public class SatisDetay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SatısId { get; set; }
        [Required]
        public int UrunId { get; set; }
        [Required]
        public int Miktar { get; set; }
        [Required]
        public decimal SatisFiyati  { get; set; }
        [DefaultValue(0)]
        public int PromosyonId { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }




        [ForeignKey("PromosyonId")]
        public virtual Promosyon Promosyon { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

        public virtual Satis Satis { get; set; }

    }
}
