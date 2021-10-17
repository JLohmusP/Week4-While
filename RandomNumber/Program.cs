using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //genereerib juhusliku numbri 1 kuni 10;
            //kui number = 5, lõpeta töö, kuva "Kena päeva!";
            //Kui midagi muud, jätka tööd;

            Random rnd = new Random();
            int i = 0;
            

            while (i != 5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {myRandomNumber}.");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
