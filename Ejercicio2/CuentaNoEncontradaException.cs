using System;

namespace Ejercicio2
{
    class CuentaNoEncontradaException : Exception
    {
        public CuentaNoEncontradaException(string pCadena) : base(pCadena)
        { }
    }
}
