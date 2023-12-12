using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foodType foodType = new foodType();

            foodType foodType1 = new foodType("Banana", 55, 66, 5);
            foodType foodType2 = new foodType("Jabuka", 69, 69, 69);
            foodType foodType3 = new foodType("Pašta", 100, 250, 50);

            Console.WriteLine(foodType.getCounter());

            Console.WriteLine(foodType1.ToString());
            Console.WriteLine(foodType2.ToString());
            Console.WriteLine(foodType3.ToString());




            Console.ReadKey();
        }
    }
}
