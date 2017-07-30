using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Entity
{
    [Table("UyeTipleri")]
    public class UyeTipleri
    {
        [Key]
        public int UyeTipleriID { get; set; }
        public string UyeTipiAdi { get; set; }

        public virtual ICollection<Uyeler> Uyeler { get; set; }
    }
}
