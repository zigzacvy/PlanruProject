using Planru.Core.Services;
using Planru.Plugins.Directory.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Plugins.Directory.Services
{
    public interface IGroupService : IService<GroupDTO, Guid>
    {
    }
}
