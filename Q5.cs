    using System; // use basic system functionalities

    namespace ConsoleApplication1 // define a namespace for organization

    {

        class Q5 // define a class named Program

        {

            static void Main(string[] args) // main entry point of the program

            {

                int n, fact = 1; // declare variables for number and factorial

                Console.WriteLine("Enter Number : "); // ask user to input a number 

                string str = Console.ReadLine(); // read user input as a string
                                            

                n = Convert.ToInt32(str);  // Convert the string input to an integer

                for (int i = 1; i <= n; i++) // loop from 1 to the input number

                {

                    fact = fact * i; // calculate factorial by multiplying each number

                }

                Console.WriteLine("Factorial : {0}", fact); // output the calculated factorial



                Console.Read(); // wait for user input before closing the console window

            }

        }

    }