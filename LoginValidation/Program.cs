using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {                                                                                               
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta parool");
                string userPassWord = Console.ReadLine();

                if (userName == "admin" && userPassWord == "admin1234")
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"proovi uuesti. {3 - i} katset on jäänud.");
                }
            }

            Console.WriteLine("kena päeva!");
           
            
        }
    }
}
