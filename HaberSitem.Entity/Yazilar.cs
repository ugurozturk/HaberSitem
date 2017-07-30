using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Entity
{
    [Table("Yazilar")]
    public class Yazilar
    {
        [Key]
        public int YaziID { get; set; }
        public string YaziBasligi { get; set; }
        public string YaziAltBasligi { get; set; }
        public string YaziIceriliig { get; set; }
        public DateTime KayitTarihi { get; set; }

        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<Etiketler> Etiketler { get; set; }
    }
}
