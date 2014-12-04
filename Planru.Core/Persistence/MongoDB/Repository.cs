using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Planru.Core.Domain.Specification;
using System.Linq.Expressions;

namespace Planru.Core.Persistence.MongoDB
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

        public System.Linq.IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<TEntity> AllMatching(ISpecification<TEntity> specification)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
