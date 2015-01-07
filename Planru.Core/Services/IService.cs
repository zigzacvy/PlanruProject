using Planru.Crosscutting.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Services
{
    public interface IService<TDTO, TID>
    {
        TDTO Get(TID id);
        IEnumerable<TDTO> GetAll();
        PageResult<TDTO> GetPaged(int pageNumber, int pageSize);
        void Add(TDTO item);
        void Add(IEnumerable<TDTO> items);
        void Remove(TDTO item);
        void Remove(IEnumerable<TDTO> items);
        void Remove(TID id);
        void Remove(IEnumerable<TID> ids);
        void Modify(TDTO item);
        void Modify(IEnumerable<TDTO> items);
    }
}
