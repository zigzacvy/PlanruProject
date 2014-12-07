﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Core.Domain
{
    public abstract class EntityAudit<TID> : Entity<TID>
    {
        public virtual DateTime? CreatedDateTime { get; set; }
        public virtual DateTime? UpdatedDateTime { get; set; }
    }
}
