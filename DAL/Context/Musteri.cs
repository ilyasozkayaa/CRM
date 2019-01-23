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
    [Table("Musteriler")]
    public class Musteri
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public string TCKNo { get; set; }
        [Required]
        public string Sehir { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string EMail { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        public virtual List<Satis> Satis { get; set; }

    }
}
