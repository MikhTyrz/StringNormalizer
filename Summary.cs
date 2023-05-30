using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNormalizer
{
    class Summary    //ЭТот класс убирает пробелы и переносы. Надо еще выделить двойные абзацы
    {
        static char[] delims = new[] { '\r', '\n' };
        public string[] arr = StringNormalizer.first.Split(delims, StringSplitOptions.RemoveEmptyEntries);
        public string final;
        public string Sum()
        {
            if (StringNormalizer.first != "Please, insert the string here")

            {
                foreach (string x in arr)
                {
                    final = final + ' ' + x;
                }

                final = final.Replace("- ", "");
                final = final.Trim();
                return (final);
            }

            else
            {
                return ("Please, insert text in the value 1");
            }

        }
    }
}
