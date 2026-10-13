using System;
using System.Collections.Generic;
using System.Text;


namespace KontoBankowe
{
    internal class Automat
    {

        private int _iloscMonet;

        public void WrzucMonete(KontoBankowe konto, decimal wartoscMonety)
        {





            konto.Saldo += wartoscMonety;
        }


    }
}
