using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericsTestMaximum
{
    public class Max3IntegersFind
    {
        //using int object and compareto to find max integer
        public static int MaxthreeIntegers(int firstvalue,int secondvalue,int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
                {
                return firstvalue;
            }
            if(secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
                {
                return secondvalue;
            }
            if(thirdvalue.CompareTo(firstvalue)>0 && (thirdvalue.CompareTo(secondvalue)>0))
                {
                return thirdvalue;
            }
            throw new Exception("VALUES ARE SAME");

            
        }
    }
}
