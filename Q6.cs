using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Q6
    {
        static void Main(string[] args)

        {

            int a, b, c, result;

            Console.Write("Enter Number   1: ");

            string str = Console.ReadLine();
            a = Convert.ToInt32(str);



            Console.Write("Enter Number  2 : ");

            string str2 = Console.ReadLine();

            b = Convert.ToInt32(str2);



            Console.Write("Enter Number   3 : ");

            string str3 = Console.ReadLine();

            c = Convert.ToInt32(str3);

            



            result = Sum(a, b, c);

            Console.WriteLine(+a  + b + c);



            Console.Read();

        }

        static int Sum(int x, int y, int z)

        {

            int res;

            res = x + y + z;

            return res;

        }

    }

}
    

