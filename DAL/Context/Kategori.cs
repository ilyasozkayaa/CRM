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
    [Table("Kategoriler")]
   public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string KategoriAdi { get; set; }
        [Required]
        public string Aciklama { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }
        
        public virtual List<Urun> Uruns { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
