using HaberSitem.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSitem.Data.Repositories
{
    public class BaseRepository<TEntity> where TEntity:class
    {
        HaberSitemContext context = new HaberSitemContext();
        //Ekle,sil,guncelle,hepsinigetir,idyegoregetir
        public void Ekle(TEntity nesne)
        {
            context.Set<TEntity>().Add(nesne);
            context.SaveChanges();
        }
        public void Sil(TEntity nesne)
        {
            context.Set<TEntity>().Remove(nesne);
            context.SaveChanges();
        }
        public void Guncelle(TEntity nesne)
        {
            context.Entry(nesne).State = EntityState.Modified;
            context.SaveChanges();
        }
        public List<TEntity> HepsiniGetir()
        {
            return context.Set<TEntity>().ToList();
        }
        public TEntity IdyeGoreGetir(int id)
        {
            return context.Set<TEntity>().Find(id);
        }
    }
}
