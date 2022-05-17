using System;

namespace Enumerations
{
    internal class Program
    {
        enum Color
        {
            red,
            blue=3,
            yellow
        }
        static void Main(string[] args)
        {
           /* int myColor = (int)Color.yellow;
            Console.WriteLine(myColor);*/

            Color myColer1 = (Color)4;
            /* Console.WriteLine(myColer1);
             Console.ReadLine();*/
            switch (myColer1)
            {
                case Color.red:
                    Console.WriteLine("Day la mau do");
                    break;
                case Color.blue:
                    Console.WriteLine("Day la mau xanh");
                    break ;
                case Color.yellow:
                    Console.WriteLine("Day la mau vang");
                    break;
                    default: Console.WriteLine("Khong co mau nay");
                    break;
            }
            Console.ReadLine();
        }
    }
}
