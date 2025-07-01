using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            //string num = Console.ReadLine();
            //int number = int.Parse(num);
            int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine(number + " is a even number ");
            }
            else 
            {
                Console.WriteLine(number + " is odd number ");
            }
        }
    }
}
