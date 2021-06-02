using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        private int iAntiguedadMinima;
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        {int antiguedadEnMeses = Convert.ToInt32(DateTime.Today.Subtract(pSolicitud.Cliente.Empleo.FechaIngreso).TotalDays/30);
            return antiguedadEnMeses >= this.iAntiguedadMinima;
        }
    }
}
