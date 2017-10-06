using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Raz's Lucky Numbers Go Big Or Go Broke Lottery");
            Console.WriteLine("Please select the starting number");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the ending number");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Select your 6 \"lucky\" numbers (press enter after each #)");
           
            int[] luckyNumbers = new int[6];
            for (int i = 0; i <= luckyNumbers.Length; i++)

            {

                luckyNumbers[i] = int.Parse(Console.ReadLine());

                if (luckyNumbers[i] > endNumber)
                {
                    Console.WriteLine("This number is invalid. Please enter a valid number.");
                    continue;
                }
               
            }














        }
    }
}
