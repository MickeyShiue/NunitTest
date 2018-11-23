using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mickey.DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
       // private DbContext Context { get; set; }

        private DbSet<TEntity> DbSet { get; set; }

        private NorthwindContext Context { get; set; }

        public Repository() //照理講要用DI，但重點在於測試，這邊就偷懶^^>
        {
            Context = new NorthwindContext();
            this.DbSet = Context.Set<TEntity>();
        }

        public void Create(TEntity Entity)
        {
            this.DbSet.Attach(Entity);
            this.DbSet.Add(Entity);
        }

        public bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> query = this.DbSet;

            query = query.Where(filter);

            return query.Any();
        }

        public void SaveChange()
        {
            Context.SaveChanges();
        }
    }
}
