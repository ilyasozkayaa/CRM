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
        [StringLength(30)]
        public string Ad { get; set; }
        [Required]
        [StringLength(30)]
        public string Soyad { get; set; }
        [Required]
        [StringLength(11)]
        public string TCKNo { get; set; }
        [Required]
        [StringLength(10)]
        public string Telefon { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [StringLength(30)]
        public string DogumYeri { get; set; }
        [Required]
        [StringLength(50)]
        public string Adres { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Image { get; set; }
        [Required]
        [StringLength(1)]
        public string Cinsiyet { get; set; }
        [Required]
        public DateTime IseGirisTarihi { get; set; }
        public DateTime IstenCikisTarihi { get; set; }
        [StringLength(10)]
        public string MedeniHal { get; set; }
        [Required]
        [StringLength(10)]
        public string AskerlikDurumu { get; set; }
        [Required]
        [StringLength(10)]
        public string EngelDurumu { get; set; }
        [Required]
        [StringLength(20)]
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
