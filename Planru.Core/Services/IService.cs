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
        void Add(TDTO item);
        void Add(IEnumerable<TDTO> items);
        void Remove(TDTO item);
        void Remove(IEnumerable<TDTO> items);
        void Remove(object id);
        void Remove(IEnumerable<TID> ids);
        void Modify(TDTO item);
        void Modify(IEnumerable<TDTO> items);
    }
}
