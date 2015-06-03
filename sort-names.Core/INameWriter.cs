using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names.Core
{
    public interface INameWriter
    {
        Task WriteNamesToFileAsync(IEnumerable<Name> names);
    }
}
