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
        public NameWriter(string path)
            : base(path)
        {
        }


        public async Task WriteNamesToFileAsync(IEnumerable<Name> names)
        {
            using (var nameWriter = new StreamWriter(Path))
            {
                foreach (var name in names)
                {
                    await nameWriter.WriteLineAsync(GetLine(name));
                }
            }
        }

        private string GetLine(Name name)
        {
            return String.Format("{0}, {1}", name.LastName, name.FirstName);
        }
    }
}
