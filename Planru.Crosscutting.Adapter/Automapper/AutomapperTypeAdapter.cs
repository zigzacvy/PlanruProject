using AutoMapper;
using System;
namespace Planru.Crosscutting.Adapter.Automapper
{
    /// <summary>
    /// Automapper type adapter implementation
    /// </summary>
    public class AutomapperTypeAdapter
        : ITypeAdapter
    {
        #region ITypeAdapter Members

        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }

        #endregion

        public object Adapt(object source, Type sourceType, Type targetType)
        {
            return Mapper.Map(source, sourceType, targetType);
        }

        public IMappingExpression CreateMap<TSource, TTarget>()
        {
            throw new NotImplementedException();
        }
    }
}
