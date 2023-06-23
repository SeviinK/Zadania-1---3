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

        Console.Write("Wylosowane liczby parzyste (wersja 2): ");

        while (licznik < n)
        {
            liczba = random.Next(-4, 5) * 2;

            Console.Write(liczba);

            licznik++;
            if (licznik < n)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Ilość losowań (wersja 2): " + licznik);

        Console.ReadKey();
    }
}
