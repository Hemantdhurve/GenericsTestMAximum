using System;

namespace UC2_MaxFloat
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Generics");
            // T.C 1st position number is maximim
            Console.WriteLine("Using generics find maximum float number among three");
            float FloatMaxNumber = MaxNumberFind.MaxThreeFloat(141.1f, 29.6f, 34.5f);
            Console.WriteLine("Maximum value among them is :" + FloatMaxNumber);

            // T.C 2st position number is maximim
            //Console.WriteLine("Using generics find maximum float number among three");
            //float FloatMaxNumber = MaxNumberFind.MaxThreeFloat(29.6f, 141.1f, 34.5f);
            //Console.WriteLine("Maximum value among them is :" + FloatMaxNumber);

            //// T.C 3st position number is maximim
            //Console.WriteLine("Using generics find maximum float number among three");
            //float FloatMaxNumber = MaxNumberFind.MaxThreeFloat(29.6f, 34.5f, 141.1f);
            //Console.WriteLine("Maximum value among them is :" + FloatMaxNumber);

        }
    }
}
