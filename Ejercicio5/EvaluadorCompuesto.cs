using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class EvaluadorCompuesto : IEvaluador
    {
        private IList<IEvaluador> iEvaluadores;
        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        { this.iEvaluadores.Add(pEvaluador); }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        { int i = 0;
            bool validacion = true;
            while (i < this.iEvaluadores.Count && validacion)
            { validacion = this.iEvaluadores[i].EsValida(pSolicitud);
                i++;
            }
            return validacion; }
    }
}
