using System;
using System.Globalization;

namespace KontoNaMonety
{
    internal class Automat
    {
        private decimal[] nominaly = { 1, 2, 5};
        private int[] ilosci = new int[3];

        public void Wrzucmonete(string tekst, KontoBankowe konto)
        {
            decimal wartosc;
            bool czyLiczba = decimal.TryParse(tekst, out wartosc);

            if (!czyLiczba)
            {
                Console.WriteLine("Nieudany odczyt: " + tekst);
                return;
            }

            for (int i = 0; i < nominaly.Length; i++)
            {
                if (wartosc == nominaly[i])
                {
                    konto.Wplac(wartosc);
                    ilosci[i]++;
                    Console.WriteLine("Moneta przyjęta: " + wartosc + " zł");
                    return;
                }
            }

            Console.WriteLine("Zła moneta: " + tekst);
        }

        public void PokazMonety()
        {
            decimal suma = 0;

            for (int i = 0; i < nominaly.Length; i++)
            {
                Console.WriteLine(nominaly[i] + " zł: " + ilosci[i] + " szt.");
                suma = suma + nominaly[i] * ilosci[i];
            }

            Console.WriteLine("Łączna wartość monet: " + suma + " zł");
        }
    }
}
