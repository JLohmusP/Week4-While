using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genereeri juhuslik number 1 kuni 10;
            //kasutaja peab numbri ära arvama;
            //Äraarvamise korral kuva "Peavõit!";
            //Kaotuse korral kuva "Kaotus";
            //3 katsete arvu;
            //Genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;
            
                while (i < 3)
                {
                    Console.WriteLine("Sisesta Teie pakutud arv:");
                    int userNumber = Convert.ToInt32(Console.ReadLine());

                    if (userNumber == cpuNumber)
                    {
                        Console.WriteLine("Peavõit!");
                        i = 3;
                    }
                    else
                    {
                        i++;
                        Console.WriteLine($"Pakutud arv ei ole õige. Jäänud on {3 - i} katset.");
                    }

                    if(i == 3)
                    {
                        if(userNumber != cpuNumber)
                        {
                            Console.WriteLine("Kaotasite mängu.");
                        }
                    }
                }

                
            
            Console.WriteLine("Kena päeva!");
        }
    }
}
