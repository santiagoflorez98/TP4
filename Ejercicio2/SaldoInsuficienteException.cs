using System;

namespace Ejercicio2
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string pCadena) : base(pCadena)
        { }
    }
}
