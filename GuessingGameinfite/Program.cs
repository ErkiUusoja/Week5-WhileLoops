using System;

namespace GuessingGameinfite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            
            while (true)
            {
                Console.WriteLine("sisesta number");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                
                if(cpuRandom == userGuess)
                {
                    Console.WriteLine("tubli! Oled mängu võitnud!");
                    break;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");    
                }

            }



        }
    }
}
