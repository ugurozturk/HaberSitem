namespace HaberSitem.Data.Migrations
{
    using HaberSitem.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaberSitem.Data.Context.HaberSitemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HaberSitem.Data.Context.HaberSitemContext context)
        {
            context.Kategoriler.AddOrUpdate(
                a => a.KategoriAdi,
                new Kategoriler { KategoriAdi = "Finans" },
                new Kategoriler { KategoriAdi = "Dünya" }
                );

            context.UyeTipleri.AddOrUpdate(
                a => a.UyeTipiAdi,
                new UyeTipleri { UyeTipiAdi = "Admin"},
                new UyeTipleri { UyeTipiAdi = "Mod"},
                new UyeTipleri { UyeTipiAdi = "User"}
                );

            context.Uyeler.AddOrUpdate(
                a => a.Email,
                 new Uyeler { Adi = "Uður", SoyAdi = "Öztürk", Email = "asd@deneme.com"}

                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
