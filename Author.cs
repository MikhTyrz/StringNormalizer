using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringNormalizer
{
    class Author
    {
        private string final;
        public string Auth()
        {
            final = Regex.Replace(StringNormalizer.first, @"[0-9]", "");
            final = final.Replace("\r\n", " ");
            final = final.Replace(". " , ".");    //Пока не работает
            final = final.Replace(" ,", ",");
            final = final.Replace(",,", ",");
            return (final);
        }
    }
}
