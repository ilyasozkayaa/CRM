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
    [Table("Personeller")]
   public class Personel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string TCKNo { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Cinsiyet { get; set; }
        [Required]
        public DateTime IseGirisTarihi { get; set; }
        public DateTime IstenCikisTarihi { get; set; }
        public string MedeniHal { get; set; }
        [Required]
        public string AskerlikDurumu { get; set; }
        [Required]
        public string EngelDurumu { get; set; }
        [Required]
        public string EgitimDurumu { get; set; }
        [Required]
        public int UserId { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }





        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual List<Satis> Satis { get; set; }
    }
}
