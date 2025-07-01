using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();

            Console.Write(" Enter your birthdate (dd/mm/yyyy) : ");
            string date = Console.ReadLine();

            Console.Write(" Enter your address : ");
            string address = Console.ReadLine();
            

            Console.Write("Enter your City : ");
            string city = Console.ReadLine();

            Console.Write("Enter your Pincode :  ");
            string PinInput = Console.ReadLine();
            int pin = int.Parse(PinInput);

            Console.Write("Enter state : ");
            string state = Console.ReadLine();

            Console.Write("Enter country : ");
            string country = Console.ReadLine();

            Console.Write("Enter Email address : ");
            string email = Console.ReadLine();

            Console.WriteLine("\n ============== PROFILE ==============");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("DOB : " + date);
            Console.WriteLine("Address :" + address);
            Console.WriteLine("City : " + city);
            Console.WriteLine("Pincode : " + pin);
            Console.WriteLine("State : " + state);
            Console.WriteLine("Country : " + country);
            Console.WriteLine("Email : " + email);

;












        }
    }
}
