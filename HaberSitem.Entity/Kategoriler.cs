using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Entity
{
    [Table("Kategoriler")]
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public virtual ICollection<Yazilar> Yazilar { get; set; }
    }
}
