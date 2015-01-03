using Planru.Core.Persistence;
using Planru.Crosscutting.Adapter;
using Planru.Crosscutting.IoC.Anotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Services
{
    public abstract class Service<TEntity, TDTO, TID> : IService<TDTO, TID>
        where TDTO : DataTransferObject<TID>
    {
        protected IRepository<TEntity, TID> _repository;

        protected ITypeAdapter _typeAdapter;

        public Service(ITypeAdapter typeAdapter, IRepository<TEntity, TID> repository)
        {
            _typeAdapter = typeAdapter;
            _repository = repository;
        }

        public TDTO Get(TID id)
        {
            var entity = _repository.Get(id);
            return (TDTO)_typeAdapter.Adapt(entity, typeof(TEntity), typeof(TDTO));
        }

        public IEnumerable<TDTO> GetAll()
        {
            var entities = _repository.GetAll();
            return entities.Select(e => (TDTO)_typeAdapter.Adapt(e, typeof(TEntity), typeof(TDTO)));
        }

        public void Add(TDTO item)
        {
            var entity = (TEntity)_typeAdapter.Adapt(item, typeof(TDTO), typeof(TEntity));
            _repository.Add(entity);
        }

        public void Add(IEnumerable<TDTO> items)
        {
            var entities = items.Select(o => (TEntity)_typeAdapter.Adapt(o, typeof(TDTO), typeof(TEntity)));
            _repository.Add(entities);
        }

        public void Remove(TDTO item)
        {
            var entity = (TEntity)_typeAdapter.Adapt(item, typeof(TDTO), typeof(TEntity));
            _repository.Remove(entity);
        }

        public void Remove(IEnumerable<TDTO> items)
        {
            
        }

        public void Remove(TID id)
        {
            
        }

        public void Remove(IEnumerable<TID> ids)
        {
            throw new NotImplementedException();
        }

        public void Modify(TDTO item)
        {
            throw new NotImplementedException();
        }

        public void Modify(IEnumerable<TDTO> items)
        {
            throw new NotImplementedException();
        }
    }
}
