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
    [Table("Urunler")]
   public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int KategoriId { get; set; }
        [Required]
        [StringLength(30)]
        public string UrunAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string Kalip { get; set; }
        [Required]
        [StringLength(20)]
        public string Beden { get; set; }
        [Required]
        [StringLength(20)]
        public string Malzemesi { get; set; }
        [Required]
        [StringLength(20)]
        public string Renk { get; set; }
        [Required]
        [StringLength(20)]
        public string ÜretimYeri { get; set; }
        [Required]
        public int StokMiktarı { get; set; }
        [Required]
        public int KritikEsik { get; set; }
        [Required]
        public decimal AlisFiyat { get; set; }
        [Required]
        public decimal SatisFiyat { get; set; }

        [DefaultValue(false)]
        public bool Silindi { get; set; }




        public virtual List<SatisDetay> SatisDetays { get; set; }


        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public virtual List<UrunStokHareket> UrunStokHarekets { get; set; }


    }
}
