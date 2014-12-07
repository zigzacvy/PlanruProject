using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Core.Domain.Specification;
using Planru.Core.Domain;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Data.Entity.Design.PluralizationServices;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using Planru.Crosscutting.IoC.Anotations;

namespace Planru.Core.Persistence.MongoDB
{
    public class Repository<TEntity, TID> : IRepository<TEntity, TID>
        where TEntity : Entity<TID>
    {
        private MongoCollection<TEntity> _collection;

        public Repository(MongoDatabase database)
        {
            _collection = database.GetCollection<TEntity>("users");
        }

        public void Add(TEntity item)
        {
            _collection.Insert(item);
        }

        public void Add(IEnumerable<TEntity> items)
        {
            _collection.InsertBatch(items);
        }

        public void Remove(TEntity item)
        {
            this.Remove(item.Id);
        }

        public void Remove(TID id)
        {
            _collection.Remove(Query.EQ("_id", BsonValue.Create(id)));
        }

        public void Modify(TEntity item)
        {
            _collection.Save(item);
        }

        public void Modify(IEnumerable<TEntity> items)
        {
            _collection.Save(items);
        }

        public void TrackItem(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TID id)
        {
            return _collection.FindOneById(BsonValue.Create(id));
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _collection.FindAll().AsEnumerable();
        }

        public IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification)
        {
            return _collection.Find(Query<TEntity>.Where(specification.SatisfiedBy())).AsEnumerable();
        }

        public IEnumerable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending)
        {
            IEnumerable<TEntity> result;
            if (ascending)
                result = _collection.AsQueryable().OrderBy(orderByExpression);
            else
                result = _collection.AsQueryable().OrderByDescending(orderByExpression);
            return result.Skip(pageIndex * pageCount).Take(pageCount);
        }

        public IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
        {
            return _collection.Find(Query<TEntity>.Where(filter)).AsEnumerable();
        }

        public void Dispose()
        {
            // TODO:
        }
    }
}
