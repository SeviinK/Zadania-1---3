using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = int.Parse(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadKey();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = 2 * wysokosc - 1;

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscPlusow = 2 * i + 1;
            int iloscSpacji = (szerokosc - iloscPlusow) / 2;

            Console.Write(new string(' ', iloscSpacji));
            Console.Write(new string('+', iloscPlusow));
            Console.WriteLine();
        }
    }
}
