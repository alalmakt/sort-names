﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names.Core
{
    public interface INameReader
    {
        Task<IEnumerable<Name>> ReadNamesAsync();
    }
}
