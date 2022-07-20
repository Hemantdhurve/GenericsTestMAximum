using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace UC2_MaxFloat
{
    public class MaxNumberFind
    {
        public static float MaxThreeFloat(float firstvalue, float secondvalue, float thirdvalue)
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
