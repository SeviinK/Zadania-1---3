﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        int liczba = 2; 
        int licznik = 0; 

        Console.WriteLine("Pierwsze " + n + " liczb:");

        while (licznik < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }
            liczba++;
        }

        Console.ReadKey();
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i * i <= liczba; i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }
}