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
      public class GorevKayit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int GorevId { get; set; }
        [Required]
        public int PersonelId { get; set; }
        [DefaultValue(0)]
        public bool Tamamlandi { get; set; }
        [DefaultValue(0)]
        public bool Silindi { get; set; }


        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }
        public virtual List<Gorev> Gorevs { get; set; }
    }
    
        

    
}
