using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
   public class EvaluadorCantidadCuotas : IEvaluador
    {
        private int iCantidadMaximaCuotas;
        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            this.iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }
        public bool EsValida(SolicitudPrestamo pSolicitud)
        { return pSolicitud.CantidadCuotas <= this.iCantidadMaximaCuotas;  }
    }
}
