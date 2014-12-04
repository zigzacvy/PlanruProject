using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Services
{
    public interface IService<TDTO>
    {
        TDTO Get(object id);
        IEnumerable<TDTO> GetAll();
        void Add(TDTO item);
        void Add(IEnumerable<TDTO> items);
        void Remove(TDTO item);
        void Remove(IEnumerable<TDTO> items);
        void Remove(object id);
        void Remove(IEnumerable<object> ids);
        void Modify(TDTO item);
        void Modify(IEnumerable<TDTO> items);
    }
}
