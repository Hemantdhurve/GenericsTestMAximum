using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_MaxString
{
    class MaxThreeString
    {
        public static string MaxThreeStrings(string firstvalue, string secondvalue, string thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && (thirdvalue.CompareTo(secondvalue) > 0))
            {
                return thirdvalue;
            }
            throw new Exception("VALUES ARE SAME");
        }
    }
}
