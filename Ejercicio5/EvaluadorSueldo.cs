using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorSueldo : IEvaluador
    {
        private int iSueldoMinimo;
        public EvaluadorSueldo(int pSueldoMinimo)
        {
            this.iSueldoMinimo = pSueldoMinimo;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        { return pSolicitud.Cliente.Empleo.Sueldo >= this.iSueldoMinimo; }

    }
}
