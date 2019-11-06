using Randevu.DAL.Manager;
using System.Collections.Generic;

namespace Randevu.BLL
{
    public class BaseController<TEntity> where TEntity:class
    {
        BaseManager<TEntity> manager;
        public void Add(TEntity entity)
        {
            manager = new BaseManager<TEntity>();
            manager.AddManager(entity);
        }

        public void Update(TEntity entity)
        {
            manager = new BaseManager<TEntity>();
            manager.UpdateManager(entity);
        }
        public void Delete(TEntity entity)
        {
            manager = new BaseManager<TEntity>();
            manager.DeleteManager(entity);
        }
        public void DeleteById(TEntity entity)
        {
            manager = new BaseManager<TEntity>();
            manager.DeleteByIdManager(entity);
        }
        public TEntity GetById(int id)
        {
            manager = new BaseManager<TEntity>();
            return manager.GetByIdManager(id);
        }

        public List<TEntity> GetAll()
        {
            manager = new BaseManager<TEntity>();
            return manager.GetAllManager();
        }
    }
}
