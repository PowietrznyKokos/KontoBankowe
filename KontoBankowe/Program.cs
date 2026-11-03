namespace KontoNaMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe konto = new KontoBankowe();
            Automat automat = new Automat();

            automat.Wrzucmonete("5", konto);
            automat.Wrzucmonete("2", konto);
            automat.Wrzucmonete("0.5", konto);
            automat.Wrzucmonete("3", konto);
            automat.Wrzucmonete("abc", konto);

            automat.PokazMonety();
            Console.WriteLine("Numer konta: " + konto.Numer);
            Console.WriteLine("Stan konta: " + konto.StanKonta() + " zł");
        }
    }
}
