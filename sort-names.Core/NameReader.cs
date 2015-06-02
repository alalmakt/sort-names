using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_names.Core
{
    public class NameReader : INameReader
    {
        private string _path;

        public NameReader(string path)
        {

            if (string.IsNullOrWhiteSpace(path)) throw new ArgumentNullException("path");

            if (!File.Exists(path)) throw new ArgumentException("path");

            _path = path;
        }

        public async Task<List<Name>> ReadNamesAsync()
        {
            var list = new List<Name>();

            using (var nameStreamReader = new StreamReader(_path))
            {
                while (nameStreamReader.Peek() >= 0)
                {
                    var line = await nameStreamReader.ReadLineAsync();

                    list.Add(GetNameFromLine(line));
                }
            }

            return list;
        }

        public Name GetNameFromLine(string line)
        {
            var name = new Name();

            var seperatedName = line.Split(',');

            if (seperatedName.Count() != 2) throw new InvalidDataException(String.Format("Invalid line: {0}", line));

            name.LastName = seperatedName[0].Trim();

            name.FirstName = seperatedName[1].Trim();

            return name;
        }
    }
}
