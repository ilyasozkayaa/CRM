using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    [Table("Ürün İadeleri")]
    public class UrunIade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SatisId { get; set; }
        [Required]
        public DateTime IadeTarihi { get; set; }


        [ForeignKey("SatisId")]
        public virtual UrunStokHareket  urunStokHareket { get; set; }

    }
}
