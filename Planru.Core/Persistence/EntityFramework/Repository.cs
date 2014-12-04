using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Persistence.EntityFramework
{
    public class Repository<TEntity, TID> : IRepository<TEntity, TID>
    {
        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<TEntity> items)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Remove(TID id)
        {
            throw new NotImplementedException();
        }

        public void Modify(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Modify(IEnumerable<TEntity> items)
        {
            throw new NotImplementedException();
        }

        public void TrackItem(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TID id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> AllMatching(Domain.Specification.ISpecification<TEntity> specification)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, System.Linq.Expressions.Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetFiltered(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
