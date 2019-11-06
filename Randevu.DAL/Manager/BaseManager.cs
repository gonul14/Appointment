using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.DAL.Manager
{
    public class BaseManager<TEntity> where TEntity:class
    {
        AppointmentContext context;

        public void AddManager(TEntity entity)
        {
            context = new AppointmentContext();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }
        public void UpdateManager(TEntity entity)
        {
            context = new AppointmentContext();
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteManager(TEntity entity)
        {
            context = new AppointmentContext();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }
        public void DeleteByIdManager(TEntity entity)
        {
            context = new AppointmentContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
        public TEntity GetByIdManager(int id)
        {
            context = new AppointmentContext();
            return context.Set<TEntity>().Find(id);
        }

       
        public List<TEntity> GetAllManager()
        {
            context = new AppointmentContext();
            return context.Set<TEntity>().ToList();
        }
    }
}
