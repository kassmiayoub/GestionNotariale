using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial.repository
{
    internal interface INTER_REPOSITORY<TEntity> where TEntity : class
    {
        TEntity FindById(int Id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FindByValues(Expression<Func<TEntity, bool>> Predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> Predicate);

        void Add(TEntity Entity);

        void AddRange(IEnumerable<TEntity> Entities);

        void Remove(TEntity Entity);

        void RemoveRange(IEnumerable<TEntity> Entities);
        void SaveChanges();
    }
}
