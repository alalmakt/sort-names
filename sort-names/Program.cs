using System.IO;
using sort_names.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var path = args[0];

                var names = ReadNamesFromFile(path);

                var sortedNames = names.OrderBy(n => new { n.LastName, n.FirstName }).ToList();

                //save lines
                var sortedFileName = Path.GetFileName(path);
                var nameWriter = new NameWriter(String.Format("{0}", sortedFileName));

                var writeNamesTask = nameWriter.WriteNamesToFileAsync(sortedNames);

                writeNamesTask.Wait();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private static IEnumerable<Name> ReadNamesFromFile(string path)
        {
            var nameReader = new NameReader(path);

            var readNamesTask = nameReader.ReadNamesAsync();

            var names = readNamesTask.Result;

            return names;
        } 
    }
}
