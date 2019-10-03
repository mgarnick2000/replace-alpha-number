using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Console;

namespace replace_alpha_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = "The sunset sets at twelve o' clock.";
            string text = "\u001b)O\u0010bV\u001aJ;\u001bPPIMA9P\u0006\u0005/$Fm&Wz\u001f%Y+\u000b>\u0019>)#\u0010#_";
            AlphabetPosition(text);
        }
        public static string AlphabetPosition(string text)
        {
            char[] c = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Dictionary<char, int> alpha = new Dictionary<char, int>();
            for (char s = 'a'; s <= 'z'; s++)
            {
                int key = s - 'a' + 1;
                alpha.Add(s, key);
            }

            Regex r = new Regex("[^0-9a-zA-Z]+");

            text = r.Replace(text, "");
            text = new Regex(@"(\s+)").Replace(text, "");
            text = new Regex(@"(\d+)").Replace(text, "");

            char[] ca = text.ToLower().ToCharArray();

            List<int> val = new List<int>();

            for (var i = 0; i < ca.Length; i++)
            {

                char y = ca[i];
                val.Add(alpha[y]);

            }

            val.ToString();
            var result = String.Join(" ", val);

            WriteLine(result);
            return result;
        }


        // public static string AlphabetPosition(string text)
        // {
        //     return string.Join(" ", text.ToLower()
        //                                           .Where(c => char.IsLetter(c))
        //                                           .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
        //                                           .ToArray());
        // }
    }
}
