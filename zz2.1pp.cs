using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();
        int liczba;
        int licznik = 0;

        Console.Write("Wylosowane liczby parzyste (wersja 1): ");

        while (licznik < n)
        {
            liczba = random.Next(-8, 9);

            if (liczba % 2 == 0)
            {
                Console.Write(liczba);

                licznik++;
                if (licznik < n)
                {
                    Console.Write(", ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ilość losowań (wersja 1): " + licznik);

        Console.ReadKey();
    }
}
