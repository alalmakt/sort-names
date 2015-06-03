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
                var path = args[0] as string;

                var nameReader = new NameReader(path);

                var readNamesTask = nameReader.ReadNamesAsync();

                var names = readNamesTask.Result;

                var sortedNames = names.GroupBy(n => new { n.LastName, n.FirstName }).ToList();

                //print lines

      //     Console.ReadLine();
            }
            catch (Exception e)
            {
                throw;
            }
        

           
        }
    }
}
