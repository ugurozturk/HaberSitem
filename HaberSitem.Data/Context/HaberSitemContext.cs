using HaberSitem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Data.Context
{
    class HaberSitemContext : DbContext
    {
        public HaberSitemContext():base("Default")
        {

        }
        public virtual DbSet<Etiketler> Etiketler { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Uyeler> Uyeler { get; set; }
        public virtual DbSet<UyeTipleri> UyeTipleri { get; set; }
        public virtual DbSet<Yazilar> Yazilar { get; set; }
    }
}
