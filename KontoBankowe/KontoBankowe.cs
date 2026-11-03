using System;

namespace KontoNaMonety
{
    internal class KontoBankowe
    {
        private static int licznikKont = 0;

        private decimal _saldo = 0;
        private int _numer;

        public int Numer
        {
            get { return _numer; }
        }

        public KontoBankowe()
        {
            licznikKont++;
            _numer = licznikKont;
        }

        public decimal StanKonta()
        {
            return _saldo;
        }

        public void Wplac(decimal kwota)
        {
            if (kwota > 0)
            {
                _saldo = _saldo + kwota;
            }
        }
    }
}
