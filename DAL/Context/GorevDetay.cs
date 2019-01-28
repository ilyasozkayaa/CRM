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
    [Table("GorevDetaylari")]
    public class GorevDetay
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int GorevId { get; set; }
        [Required]
        public string DetayAdi { get; set; }        
        [DefaultValue(false)]
        public bool Silindi { get; set; }

       
        public virtual Gorev Gorev { get; set; }
    }   
}
