using System;

namespace Ejercicio1
{
    public class Matematica
    {
        public static double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            { throw new DivisionPorCeroException("El divisor no puede ser cero."); }
            return (Convert.ToDouble(pDividendo) / Convert.ToDouble(pDivisor));
        }
    }
}
