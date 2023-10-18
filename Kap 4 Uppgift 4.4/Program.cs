using System;
namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int nr1;
            int nr2;
            string menuChoice;

            do
            {
                Console.WriteLine("Välj ett av följande alternativ\n1. Subtrahera ett tal med ett annat\r\n2. Dividera ett tal med ett annat\r\n3. Avsluta programmet");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("Skriv in det första talet:");
                        nr1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in det andra talet:");
                        nr2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{nr1}+{nr2}={nr1+nr2}");//Beräkning
                        break;

                    case "2":
                        Console.WriteLine("Skriv in det första talet:");
                        nr1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in det andra talet:");
                        nr2 = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{nr1}-{nr2}={nr1 - nr2}");//Beräkning
                        break;

                    case "3":
                        loop = false; //Stänger av loopen
                        break;
                }
                Console.WriteLine();
            }
            while (loop);
            
            /*Skapa ett menyprogram som innehåller följande alternativ:
Välj ett av följande alternativ.
1. Subtrahera ett tal med ett annat
2. Dividera ett tal med ett annat
3. Avsluta programmet
Programmet ska skriva ut resultatet av en beräkning med de två tal som använder
skrev in med det räknesätt som användaren valde.*/
        }
    }
}