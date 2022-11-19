using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;
using Accounting.DataLayer;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Service
{
    class GenericServices<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        private Accounting_ProjectEntities _db;
        private DbSet<TEntity> _Dbset;

        public GenericServices(Accounting_ProjectEntities context)
        {
            _db = context;
            _Dbset = _db.Set<TEntity>();
        }
        public void Delete(TEntity entity)
        {
            _Dbset.Remove(entity);
        }

        public void Delete(int ID)
        {
           
            var delete = GetByID(ID);
            Delete(delete);
        }

        public List<TEntity> GetAllAndSearch(Expression<Func<TEntity,bool>> where=null)
        {
            IQueryable<TEntity> query = _Dbset;
            if (where == null)
            {
                return query.ToList();
            }
            return query.Where(where).ToList();
        }

        public TEntity GetByID(int ID)
        {
            return _Dbset.Find(ID);
        }

        public void Insert(TEntity entity)
        {
            _Dbset.Add(entity);
        }

        public void update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
