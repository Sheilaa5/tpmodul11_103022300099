using System;
using LibraryAljabar;

namespace AljabarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] persamaanKuadrat = { 1, -3, -10 };
            double[] akar = PersamaanKuadrat.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine("Akar-akar: " + string.Join(", ", akar));

            double[] bentukKuadrat = { 2, -3 };
            double[] hasil = PersamaanKuadrat.HasilKuadrat(bentukKuadrat);
            Console.WriteLine("Hasil kuadrat: " + string.Join(", ", hasil));
        }
    }
}


