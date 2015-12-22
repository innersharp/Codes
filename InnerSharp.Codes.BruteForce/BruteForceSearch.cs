using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerSharp.Codes.Search
{
    public class BruteForceSearch
    {
        public char[] Text { get; set; }
        public char[] Pattern { get; set; }

        public int IndexOf()
        {
            int textLength = Text.Length;
            int pattenLength = Pattern.Length;

            for (int i = 0; i < (textLength - pattenLength); i++)
            {
                int j = 0;
                while (j < pattenLength && Text[i + j] == Pattern[j])
                {
                    j++;
                }
                if (j == pattenLength) return i;
            }
            return -1;
        }
    }
}
