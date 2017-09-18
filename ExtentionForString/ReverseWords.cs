using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionForString
{
    public static class ExtentionMethod
    {
        public static string ReverseWords(this string original)
        {
            char[] chars = original.ToCharArray();
            ReverseCharArray(chars, 0, chars.Length - 1);
            int wordStart = 0;
            while (wordStart < chars.Length)
            {
                while (wordStart < chars.Length - 1 &&
                       !char.IsLetter(chars[wordStart]))
                    wordStart++;

                int wordEnd = wordStart;
                while (wordEnd < chars.Length - 1 &&
                       char.IsLetter(chars[wordEnd + 1]))
                    wordEnd++;

                if (wordEnd > wordStart)
                {
                    ReverseCharArray(chars, wordStart, wordEnd);
                }

                wordStart = wordEnd + 1;
            }
            return new string(chars);
        }

        static void ReverseCharArray(char[] chars, int left, int rigth)
        {
            int l = left;
            int r = rigth;
            while (l < r)
            {
                char temp = chars[l];
                chars[l] = chars[r];
                chars[r] = temp;

                l++;
                r--;

            }

        }
    }
}
