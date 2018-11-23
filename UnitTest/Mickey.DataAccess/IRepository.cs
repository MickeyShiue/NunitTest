using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mickey.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity Entity);

        bool Exists(Expression<Func<TEntity, bool>> filter);

        void SaveChange();
    }
}
