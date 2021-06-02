using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class GestorPrestamos
    {
        private IDictionary<TipoCliente,EvaluadorCompuesto> iEvaluadoresPorCliente;
        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, EvaluadorCompuesto>();

            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(5000);

            EvaluadorCompuesto evaluadorNoCliente = new EvaluadorCompuesto();
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorMonto(20000));
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
            evaluadorNoCliente.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorNoCliente.AgregarEvaluador(evaluadorEdad);
            evaluadorNoCliente.AgregarEvaluador(evaluadorSueldo);

            EvaluadorCompuesto evaluadorCliente = new EvaluadorCompuesto();
            evaluadorCliente.AgregarEvaluador(new EvaluadorMonto(100000));
            evaluadorCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(32));
            evaluadorCliente.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorCliente.AgregarEvaluador(evaluadorEdad);
            evaluadorCliente.AgregarEvaluador(evaluadorSueldo);

            EvaluadorCompuesto evaluadorClienteGold = new EvaluadorCompuesto();
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorMonto(150000));
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            evaluadorClienteGold.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorClienteGold.AgregarEvaluador(evaluadorEdad);
            evaluadorClienteGold.AgregarEvaluador(evaluadorSueldo);

            EvaluadorCompuesto evaluadorClientePremium = new EvaluadorCompuesto();
            evaluadorClientePremium.AgregarEvaluador(new EvaluadorMonto(200000));
            evaluadorClientePremium.AgregarEvaluador(new EvaluadorCantidadCuotas(60)); 
            evaluadorClientePremium.AgregarEvaluador(evaluadorAntiguedadLaboral);
            evaluadorClientePremium.AgregarEvaluador(evaluadorEdad);
            evaluadorClientePremium.AgregarEvaluador(evaluadorSueldo);

            this.iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, evaluadorNoCliente);
            this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, evaluadorCliente);
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, evaluadorClienteGold);
            this.iEvaluadoresPorCliente.Add(TipoCliente.ClientePremium, evaluadorClientePremium);



        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {  EvaluadorCompuesto evaluador = new EvaluadorCompuesto();
            this.iEvaluadoresPorCliente.TryGetValue(pSolicitud.Cliente.TipoCliente, out evaluador);
                return evaluador.EsValida(pSolicitud); }

    }
}
