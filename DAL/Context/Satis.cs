
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
    [Table("Satislar")]
   public class Satis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Tarih { get; set; }
        [Required]
        public int MusteriId { get; set; }
        [Required]
        public int PersonelId { get; set; }
        [DefaultValue(0)]
        public bool Silindi { get; set; }




        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }
        [ForeignKey("MusteriId")]
        public virtual Musteri Musteri { get; set; }

        public virtual List<SatisDetay> SatisDetays { get; set; }
    }
}
