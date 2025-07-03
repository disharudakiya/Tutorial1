using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Q4
    
        


        {
            static void Main(string[] args)
            {
                int x;
                Console.Write("Enter Number: ");
                string str = Console.ReadLine();       // First read input
                x = Convert.ToInt32(str);              // Then convert

                if (x % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }

                Console.ReadLine();  
            }
        }
    }



