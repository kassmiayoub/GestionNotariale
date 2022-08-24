using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using gestion_cabinet_notarial.context;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial.repository
{
    public class CLS_REPOSITORY<TEntity> : INTER_REPOSITORY<TEntity> where TEntity : class
    {
        protected readonly gestion_cabinet_cotarialEntities Context = new gestion_cabinet_cotarialEntities();
        protected DbSet DbSetEntity;
        public CLS_REPOSITORY()
        {
            //DbSetEntity = Context.Set<TEntity>();
            DbSetEntity = Context.Set<TEntity>();
        }

        public void Add(TEntity Entity)
        {
            DbSetEntity.Add(Entity);
            Context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> Entities)
        {
            DbSetEntity.AddRange(Entities);
            Context.SaveChanges();
        }

        public TEntity FindById(int Id) => Context.Set<TEntity>().Find(Id);

        public IEnumerable<TEntity> FindByValues(Expression<Func<TEntity, bool>> Predicate) => Context.Set<TEntity>().Where(Predicate);

        public IEnumerable<TEntity> GetAll() => Context.Set<TEntity>().ToList();

        public void Remove(TEntity Entity) => DbSetEntity.Remove(Entity);

        public void RemoveRange(IEnumerable<TEntity> Entities) => DbSetEntity.RemoveRange(Entities);
        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> Predicate) => Context.Set<TEntity>().SingleOrDefault(Predicate);
        public int GetNextAutoIncrement(Expression<Func<TEntity, int>> Predicate)
        => Context.Set<TEntity>().Count() == 0 ? 1 : Context.Set<TEntity>().Max(Predicate) + 1;

        public bool Any(Expression<Func<TEntity, bool>> Predicate) => Context.Set<TEntity>().Any(Predicate);
        public int Count(Expression<Func<TEntity, bool>> Predicate) => Context.Set<TEntity>().Count(Predicate);
        public void SaveChanges() => Context.SaveChanges();
    }
}
