using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names.Core
{
    public abstract class FileAccessor
    {
        protected string Path;

        protected FileAccessor(string path)
        {

            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException("path");

            if (!File.Exists(path)) throw new ArgumentException("path");

            Path = path;
        }
      
    }
}
