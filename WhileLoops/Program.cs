using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN-koodi;
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            // kui sisestatud PIN-kood on 1234, siis konsool kuvab "tere tulemast"
            //kui sisestatud PIN-kood on midagi muud, konsool kuvab "Vale PIN. Proovi uuesti."
            //tingimus 1. katsete arv on piiramatu


            //boolean = true/false



            /* while (true)
             {
                 Console.WriteLine("sisesta PIN-kood:");
                 int userPIN = Convert.ToInt32(Console.ReadLine());

                 if(userPIN == 1234)
                 {
                     Console.WriteLine("Tere tulemast!");
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Vale PIN. Proovi uuesti.");
                 }
             }*/
            //tingimus 2. kasutajal on kolm katset

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN.{3 -1} katset on jäänud");
                }
            }




            Console.WriteLine("kena päeva!");
        }
    }
}
