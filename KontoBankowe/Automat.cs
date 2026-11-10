using automat;
using System.Globalization;

class Automat
{
    private List<double> monety = new List<double>();
    private double[] nominaly = [5, 2, 1, 0.5, 0.2, 0.1];
    private int[] pojemosc = [10, 5, 3, 5, 5, 5];
    private int[] iloscMonet = [0, 0, 0, 0, 0, 0];

    public void WrzucMonete(string tekst)
    {
        string[] czesci = tekst.Split(" ");
        for (int i = 0; i < czesci.Length; i++)
        {
            double wartoscMonety = 0;
            if (double.TryParse(czesci[i], NumberStyles.Float, CultureInfo.InvariantCulture, out wartoscMonety))
            {
                bool czyPrzyjmuje = false;
                for (int j = 0; j < nominaly.Length; j++)
                {
                    if (nominaly[j] == wartoscMonety)
                    {
                        czyPrzyjmuje = true;
                        break;
                    }
                }
                if (czyPrzyjmuje)
                {
                    if (iloscMonet[Array.IndexOf(nominaly, wartoscMonety)] == pojemosc[Array.IndexOf(nominaly, wartoscMonety)])
                    {
                        Console.WriteLine("Skonczylo sie miejsce na monete: " + wartoscMonety);

                    }
                    else
                    {
                        Console.WriteLine("Moneta przyjęta: " + wartoscMonety + " zł");
                        monety.Add(wartoscMonety);
                        iloscMonet[Array.IndexOf(nominaly, wartoscMonety)]++;
                    }
                }
                else
                {
                    Console.WriteLine("Zła moneta: " + wartoscMonety);
                }

            }
            else
            {
                Console.WriteLine("Zła moneta");
            }
        }
    }

    public void PokazMonety()
    {

        for (int i = 0; i < nominaly.Length; i++)
        {
            Console.Write(nominaly[i] + ": ");
            int licznik = 0;

            for (int j = 0; j < monety.Count; j++)
            {

                if (nominaly[i] == monety[j])
                {
                    licznik++;
                }
            }
            Console.Write(licznik + ", ");
        }


    }
    public void Wplac(KontoBankowe konto)
    {
        double sum = 0;
        for (int i = 0; i < monety.Count; i++)
        {
            sum += monety[i];
        }
        konto.Wplac(sum);
        monety.Clear();

    }

}