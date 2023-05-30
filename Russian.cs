using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNormalizer
{
    class Russian
    {
        static char[] delims = new[] { ' ', '-', '\r', '\n' };
        public string[] arr = StringNormalizer.first.ToLower().Split(delims, StringSplitOptions.RemoveEmptyEntries);
        private string final;
        public string Rus()
        {
            if (StringNormalizer.first != "Please, insert the string here")

            {
                final = string.Join(" ", arr);
                final = final.Trim();
                final = char.ToUpper(final[0]) + final.Substring(1);
                return (final);
            }

            else
            {
                return ("Please, insert text in the value 1");
            }
        }
    }
}
