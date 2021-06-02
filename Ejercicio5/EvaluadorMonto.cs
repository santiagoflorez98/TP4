using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
  public class EvaluadorMonto : IEvaluador
    {
        private double iMontoMaximo;
        public EvaluadorMonto(double pMontoMaximo)
        {
            this.iMontoMaximo = pMontoMaximo;
        }
        public Boolean EsValida(SolicitudPrestamo pSolicitud)
        { return pSolicitud.Monto<=this.iMontoMaximo; }
    }
}
