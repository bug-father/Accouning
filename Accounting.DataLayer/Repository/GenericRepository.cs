using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;

namespace Accounting.DataLayer.Repository
{
    public interface GenericRepository<TEntity> where TEntity:class
    {
         List<TEntity> GetAllAndSearch(System.Linq.Expressions.Expression<Func<TEntity, bool>> where = null);
        TEntity GetByID(int ID);
        void update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int ID);
        void Insert(TEntity entity);
    }
}
