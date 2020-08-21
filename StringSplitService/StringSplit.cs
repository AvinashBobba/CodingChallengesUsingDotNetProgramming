using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringSplitService
{
    public static class StringSplit
    {
        public static int SplitAString(string S)
        {
            string[] parts;

            parts = S.Split('a');
            if ((parts.Length - 1) % 3 != 0)
            {
                return 0;
            }
               
            var count = (parts.Length - 1) / 3;

            int partA1 = parts[count].Length + 1;
            int partA2 = parts[count * 2].Length + 1;
            return partA1 * partA2;
        }

    }
}
