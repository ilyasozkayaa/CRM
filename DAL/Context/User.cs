using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    [Table("Users")]
   public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public string YetkiDüzeyi { get; set; }




        public virtual List<Personel> Personels { get; set; }
    }
}
