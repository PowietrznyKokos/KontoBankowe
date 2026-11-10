using System.Globalization;

namespace automat
{
    class KontoBankowe
    {
        private static int numer = 0;
        private double stanKonta = 0;
        public int id = 0;

        public List<double> historiaWplat = new List<double>();

        public KontoBankowe()
        {
            numer++;
            id = numer;
        }

        public void Wplac(double kwota)
        {
            stanKonta += kwota;
            dodajDoHistorii(kwota);

        }

        public double StanKonta()
        {
            return stanKonta;
        }

        public void dodajDoHistorii(double wplata)
        {
            historiaWplat.Add(wplata);
        }

        public void pokazHistorie()
        {
            Console.Write("\nWplat bylo: " + historiaWplat.Count);
            Console.Write("\nWplaty: ");
            for (int i = 0; i < historiaWplat.Count; i++)
            {
                Console.Write(historiaWplat[i] + ", ");
            }
            Console.Write("\n");
        }


    }
}
    