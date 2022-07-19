using System;

namespace UsingGenericsTestMaximum
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Generics");
            Console.WriteLine("Using generics find maximum number among three integers");

            // create int object 
            //in T.C 1=MAX NUMBER IS AT 1ST POSITION i.e 40 taken and so on
           
            int MaxNumber = Max3IntegersFind.MaxthreeIntegers(40,30,20);
            Console.WriteLine("Maximum value among them is :"+ MaxNumber);

            //in T.C 2=max number is at 2nd position

            //int MaxNumber = Max3IntegersFind.MaxthreeIntegers(30, 40, 20);
            //Console.WriteLine("Maximum value among them is :" + MaxNumber);


            //in T.C 3=max number is at 3nd position

            //int MaxNumber = Max3IntegersFind.MaxthreeIntegers(20, 30, 40);
            //Console.WriteLine("Maximum value among them is :" + MaxNumber);
        }
    }
}