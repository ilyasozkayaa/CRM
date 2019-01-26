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
    [Table("Ürün Stok Hareketleri")]
   public class UrunStokHareket
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //public int UrunId { get; set; }       
        [Required]
        public int Miktar { get; set; }
        [Required]
        
        public string IslemTürü { get; set; }

        //[ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
        public virtual List<UrunIade> UrunIade { get; set; }
    }
}
