﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planru.Crosscutting.Adapter
{
    public interface IMappingExpression
    {
        IMappingExpression ForMember();
    }
}
