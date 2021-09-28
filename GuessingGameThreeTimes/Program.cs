using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            int i = 0;

            while (true)
            {
                Console.WriteLine("tubli! oled mängu võitnud!");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userGuess)
                {
                    Console.WriteLine("tubli! Oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++; //i= i + 1
                    Console.WriteLine($"Proovi uuesti! {3 - i} katset on jäänud.");
                }
            }
            if(i == 3)
            {
                Console.WriteLine("Oled m'ngu kaotanud.");
            }

            
        }
    }
}
