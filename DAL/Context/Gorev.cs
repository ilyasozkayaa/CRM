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
     public class Gorev
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GorevAdi { get; set; }        
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        [DefaultValue(0)]
        public bool Tamamlandi { get; set; }
        [DefaultValue(0)]
        public bool Silindi { get; set; }
      
        public virtual List<GorevDetay> GorevDetays { get; set; }
    }
}
