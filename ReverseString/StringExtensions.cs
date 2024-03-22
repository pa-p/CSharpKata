using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public static class StringExtensions
    {
        public static string ReverseWords(this string s)
        {
            if (s is null)
                return "";

            if (s.Length == 0) 
                return s;

            var words = s.Split(" ");
                                  
            return string.Join(
                " ",
                words.Where(w => !string.IsNullOrWhiteSpace(w)).Reverse());
        }
    }
}
