using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Services
{
    /// <summary>
    /// Data transfer object
    /// </summary>
    /// <typeparam name="TId">The type of data key</typeparam>
    public class DataTransferObject<TID>
    {
        public virtual TID Id { get; set; }
    }
}
