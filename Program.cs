using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] homersekletek = new double[7];
            double osszeg = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Kérem a(z) {i + 1}. nap hőmérsékletét (°C): ");
                while (!double.TryParse(Console.ReadLine(), out homersekletek[i]))
                {
                    Console.WriteLine("Kérlek, érvényes számot adj meg!");
                }
                osszeg += homersekletek[i];
            }

            double atlag = osszeg / 7;
            double legmelegebb = homersekletek[0];
            double leghidegebb = homersekletek[0];

            foreach (var h in homersekletek)
            {
                if (h > legmelegebb) legmelegebb = h;
                if (h < leghidegebb) leghidegebb = h;
            }

            Console.WriteLine($"\nA hét átlaghőmérséklete: {atlag:F2} °C");
            Console.WriteLine($"A legmelegebb nap hőmérséklete: {legmelegebb} °C");
            Console.WriteLine($"A leghidegebb nap hőmérséklete: {leghidegebb} °C");

            if (Array.Exists(homersekletek, h => h < 0))
            {
                Console.WriteLine("Fagypont alatti nap is volt!");
            }
        }
    }
}

