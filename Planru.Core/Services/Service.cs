using Planru.Core.Domain;
using Planru.Core.Persistence;
using Planru.Crosscutting.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Services
{
    public abstract class Service<TEntity, TDTO, TID> : IService<TDTO, TID>
        where TDTO : DataTransferObject<TID>
        where TEntity : Entity<TID>
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
            return ConvertToDTO(entity);
        }

        public IEnumerable<TDTO> GetAll()
        {
            var entities = _repository.GetAll();
            return ConvertToDTOs(entities);
        }

        public void Add(TDTO item)
        {
            var entity = ConvertToEntity(item);
            _repository.Add(entity);
        }

        public void Add(IEnumerable<TDTO> items)
        {
            var entities = ConvertToEntities(items);
            _repository.Add(entities);
        }

        public void Remove(TDTO item)
        {
            var entity = ConvertToEntity(item);
            _repository.Remove(entity);
        }

        public void Remove(IEnumerable<TDTO> items)
        {
            var entities = ConvertToEntities(items);
            _repository.Remove(entities);
        }

        public void Remove(TID id)
        {
            _repository.Remove(id);
        }

        public void Remove(IEnumerable<TID> ids)
        {
            _repository.Remove(ids);
        }

        public void Modify(TDTO item)
        {
            var entity = ConvertToEntity(item);
            _repository.Modify(entity);
        }

        public void Modify(IEnumerable<TDTO> items)
        {
            var entities = ConvertToEntities(items);
            _repository.Modify(entities);
        }

        #region Helper methods
        /// <summary>
        /// Converts an entity object to a data transfer object
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected TDTO ConvertToDTO(TEntity entity)
        {
            return (TDTO)_typeAdapter.Adapt(entity, typeof(TEntity), typeof(TDTO));
        }

        /// <summary>
        /// Converts entity objects to data transfer objects
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        protected IEnumerable<TDTO> ConvertToDTOs(IEnumerable<TEntity> entities)
        {
            return entities.Select(e => (TDTO)_typeAdapter.Adapt(e, typeof(TEntity), typeof(TDTO)));
        }

        /// <summary>
        /// Converts a data transfer object to an entity object
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        protected TEntity ConvertToEntity(TDTO dto)
        {
            return (TEntity)_typeAdapter.Adapt(dto, typeof(TDTO), typeof(TEntity));
        }

        /// <summary>
        /// Converts data transfer objects to entity objects
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        protected IEnumerable<TEntity> ConvertToEntities(IEnumerable<TDTO> dtos)
        {
            return dtos.Select(o => (TEntity)_typeAdapter.Adapt(o, typeof(TDTO), typeof(TEntity)));
        }
        #endregion
    }
}
