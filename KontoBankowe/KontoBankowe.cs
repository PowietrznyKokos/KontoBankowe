using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankowe
{
    internal class KontoBankowe
    {
        private decimal _saldo;

        private string _numer;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
    }
}
