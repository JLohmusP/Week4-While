using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genereeri juhuslik number 1 kuni 10;
            //kasutaja peab numbri ära arvama;
            //Äraarvamise korral kuva "Peavõit!";
            //katsete arv piiramatu;
            //Genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta Teie pakutud arv:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if(userNumber == cpuNumber)
                {
                    Console.WriteLine("Peavõit!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
