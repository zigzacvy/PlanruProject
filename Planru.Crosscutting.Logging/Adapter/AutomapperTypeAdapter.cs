﻿using AutoMapper;
using Planru.Crosscutting.Adapter;

namespace Planru.Crosscutting.NetFramework.Adapter
{
    /// <summary>
    /// Automapper type adapter implementation
    /// </summary>
    public class AutomapperTypeAdapter
        :ITypeAdapter
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
    }
}
