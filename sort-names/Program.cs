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
            var path = args[0] as string;

            var nameReader = new NameReader(path);
            
            Console.ReadLine();
        }
    }
}
