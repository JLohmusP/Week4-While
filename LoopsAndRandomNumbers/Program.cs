using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Küsi PIN-koodi;
            //Võrdle sisestatud PIN-koodi arvuga 69420;
            //Kui sisestatud PIN-kood on 69420, kuva "Tere tulemast!";
            //Kui midagi muud, kuva "Vale PIN. Proovi uuesti.";
            //Kasutajal on kolm katset;

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 69420)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN-kood. Proovi uuesti. {3 - i} katset jäänud.");
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
