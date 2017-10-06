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
            
            double jackpot = 100.00;
            Console.WriteLine("Welcome to Raz's Lucky Numbers Go Big Or Go Broke Lottery");
            Console.WriteLine("Please select the starting number");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the ending number");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Select your 6 \"lucky\" numbers within that range. (press enter after each #)");

            int[] luckyNumbers = new int[6];
            for (int i = 0; i < luckyNumbers.Length; i++)

            {
                luckyNumbers[i] = int.Parse(Console.ReadLine());

                if (luckyNumbers[i] > endNumber)
                {
                    Console.WriteLine("This number is invalid. Please enter a valid number.");
                    continue;
                }
                else if (luckyNumbers[i] < startNumber)
                {
                    Console.WriteLine("This number is invalid. Please enter a valid number.");
                    continue;

                }
            }

            Console.WriteLine("I will now attempt to guess 6 random numbers within your range.");
            Console.WriteLine("If you guessed all the numbers correctly, you win the jackpot of $" + jackpot + ".");
            Console.WriteLine("You will get a % amount of the jackpot depending on the matching numbers.");

            double userWin = 0;
            double userMoney = 0;


            int[] randomGenerator = new int[6];
            Random rand = new Random();
            for (int number = 0; number < 6; number++)
            {

                int randomNumber = rand.Next(startNumber, endNumber) + 1;
                randomGenerator[number] = randomNumber;
                Console.WriteLine("Lucky number: " + randomGenerator[number]);
            }

           




            for (int i = 0; i < 6; i++)
            {
                if (randomGenerator.Contains(luckyNumbers[i]))
                {
                    userMoney++;
                }
              
            }


           
            Console.WriteLine("You guessed " + userMoney +" numbers correctly!");

            userWin = userMoney * (jackpot / 6);

            Console.WriteLine("You win $" + userWin);

            Console.WriteLine("Do you want to play again? YES/NO");
            string playAgain = Console.ReadLine().Trim().ToUpper();

            //while (playAgain == "YES")

        





















        }
    }
}
