using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            
            string userName = Console.ReadLine();
              
            Console.WriteLine($"{userName}, please give me a number to check to see if it is even or odd.");
            MyMethodOne();
        }
        public static bool MyMethodOne()
        {
            int userNumber;
           
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Your number is even");
                return true;
            }
            else
            {
                Console.WriteLine("Your number is odd!");
                return false;
            }
                         
            
            

            
            

        }
	

	}
            

    }

