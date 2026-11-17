using System;

namespace automat
{
    internal class Bankomat
    {
        private double[] nominaly = [0.1, 0.2, 0.5, 1, 2, 5];
        private int[] iloscMonet = [0, 0, 0, 0, 0, 0];
        public void ZaladujMonety(double nominal, int ilosc)
        {
            int indeks = Array.IndexOf(nominaly, nominal);

            if (indeks == -1)
            {
                Console.WriteLine("Zly nominal: " + nominal + " zl. Nic nie zaladowano.");
                return;
            }

            iloscMonet[indeks] += ilosc;
            Console.WriteLine("Zaladowano " + ilosc + " monet po " + nominal + " zl");
        }

        public void Wyplac(KontoBankowe konto, double kwota)
        {
            int pozostalo = (int)Math.Round(kwota * 100);

            if (kwota > konto.StanKonta())
            {
                Console.WriteLine("Odmowa: brak srodkow na koncie");
                return;
            }

            int[] doWydania = [0, 0, 0, 0, 0, 0];

            for (int i = nominaly.Length - 1; i >= 0; i--)
            {
                int nominalGrosze = (int)Math.Round(nominaly[i] * 100);

                int ile = pozostalo / nominalGrosze;

                if (ile > iloscMonet[i])
                {
                    ile = iloscMonet[i];
                }

                doWydania[i] = ile;
                pozostalo = pozostalo - ile * nominalGrosze;
            }

            if (pozostalo != 0)
            {
                Console.WriteLine("Odmowa: bankomat nie moze wydac dokladnie " + kwota + " zl");
                return;
            }

            konto.Wyplac(kwota);
            Console.WriteLine("Wyplacono " + kwota + " zl:");

            for (int i = nominaly.Length - 1; i >= 0; i--)
            {
                if (doWydania[i] > 0)
                {
                    iloscMonet[i] -= doWydania[i];
                    Console.WriteLine(nominaly[i] + " zl: " + doWydania[i] + " szt.");
                }
            }
        }

        public void PokazMonety()
        {
            int sumaGrosze = 0;

            for (int i = 0; i < nominaly.Length; i++)
            {
                Console.WriteLine(nominaly[i] + " zl: " + iloscMonet[i] + " szt.");
                sumaGrosze += iloscMonet[i] * (int)Math.Round(nominaly[i] * 100);
            }

            Console.WriteLine("Razem w pojemniku: " + sumaGrosze / 100.0 + " zl");
        }
    }
}
