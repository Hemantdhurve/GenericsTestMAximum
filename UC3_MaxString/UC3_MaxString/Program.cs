using System;

namespace UC3_MaxString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Generics");

            //// // create string object 
            ////in T.C 1 
            //Console.WriteLine("Using generics find String  among three");
            //string StringMaxNumber = MaxThreeString.MaxThreeStrings("Apple", "Peach", "Banana");
            //Console.WriteLine("Maximum value among them is :" + StringMaxNumber);

            //in T.C 2 
            Console.WriteLine("Using generics find String  among three");
            string StringMaxNumber = MaxThreeString.MaxThreeStrings("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum value among them is :" + StringMaxNumber);

            ////in T.C 3 
            //Console.WriteLine("Using generics find String  among three");
            //string StringMaxNumber = MaxThreeString.MaxThreeStrings("Apple", "Peach", "Banana");
            //Console.WriteLine("Maximum value among them is :" + StringMaxNumber);
        }
    }
}


