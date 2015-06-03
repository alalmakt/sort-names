using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names.Core
{
    public class NameWriter : FileAccessor, INameWriter 
    {
        public NameWriter(string path) : base(path)
        {
        }

        public void WriteNamesToFile(IList<Name> names)
        {
            using (var nameWriter = new StreamWriter(Path))
            {
                
            }
        }
    }
}
