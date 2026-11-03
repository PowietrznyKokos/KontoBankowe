namespace KontoNaMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe kontoBankowe = new KontoBankowe();

            KontoBankowe konto = new KontoBankowe();
            Automat automat = new Automat();

            automat.Wrzucmonete("5", konto);
            automat.Wrzucmonete("2", konto);


            Console.WriteLine("Stan konta: " + konto.StanKonta() + " zł");
        }
    }
}