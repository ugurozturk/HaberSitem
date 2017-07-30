using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Entity
{
    [Table("Etiketler")]
    public class Etiketler
    {
        [Key]
        public int EtiketID { get; set; }
        public string EtiketAdi { get; set; }

        public virtual ICollection<Yazilar> Yazilar { get; set; }
    }
}
