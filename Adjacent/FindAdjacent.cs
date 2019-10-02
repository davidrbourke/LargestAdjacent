using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adjacent
{
    public class FindAdjacent
    {
        public static long GetResult(string searchArea,  int len)
        {
            long largestNum = 0;

            for (var i = 0; i < searchArea.Length - (len-1); i++)
            {
                var sub = searchArea.Substring(i, len);
                var spl = sub.Select(sub => char.GetNumericValue(sub))
                    .Aggregate((a, b) => a * b);
                
                if (spl > largestNum)
                {
                    largestNum = (long)spl;
                }
            }

            return largestNum;
        }
    }
}
