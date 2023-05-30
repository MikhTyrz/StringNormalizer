using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringNormalizer
{
    class English
    {
        static char[] delims = new[] { ' ', '-', '\r', '\n' };
        public string[] arr = StringNormalizer.first.ToLower().Split(delims, StringSplitOptions.RemoveEmptyEntries);
        private string final;
        public string Engl()
        {
           if (StringNormalizer.first != "Please, insert the string here")

            {
                foreach (string x in arr)
                {
                    string y = x.Substring(0, 1).ToUpper() + x.Remove(0, 1).ToLower();
                    if (x.Substring(0, 1) == "(")
                    {
                        y = x.Substring(0, 2).ToUpper() + x.Remove(0, 2).ToLower();
                    }
                    
                    if (y == "Of") { y = y.ToLower(); }
                    else if (y == "The") { y = y.ToLower(); }
                    else if (y == "On") { y = y.ToLower(); }
                    else if (y == "In") { y = y.ToLower(); }
                    else if (y == "And") { y = y.ToLower(); }
                    else if (y == "A") { y = y.ToLower(); }
                    else { }
                    final = final + ' ' + y;
                }

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
