using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Entity
{
    [Table("Uyeler")]
    public class Uyeler
    {
        [Key]
        public int UyelerID { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime KayitTarihi { get; set; }

        public virtual UyeTipleri UyeTipleri { get; set; }
    }
}
