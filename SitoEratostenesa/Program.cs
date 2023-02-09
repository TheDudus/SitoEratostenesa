using System;

namespace SitoEratostenesa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę większą niż 2:");
            int n = int.Parse(Console.ReadLine());
            
            bool[] primeArr = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                primeArr[i] = true;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (primeArr[i] == true)
                {
                    for (int x = i * 2; x <= n; x += i)
                    {
                        primeArr[x] = false;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze z zakresu [2," + n + "]: ");
            for (int i = 2; i <= n; i++)
            {
                if (primeArr[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}