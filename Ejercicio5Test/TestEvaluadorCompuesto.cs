using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio5;
using Xunit;

namespace Ejercicio5Test
{
    public class TestEvaluadorCompuesto
    { [Fact]
        public void TestEvaluadorCompuestoEsValidaFunciona()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(6000);
            EvaluadorCantidadCuotas evaluadorCantidadCuotas = new EvaluadorCantidadCuotas(18);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 18, unCliente);
            EvaluadorCompuesto evaluador = new EvaluadorCompuesto();
            evaluador.AgregarEvaluador(evaluadorMonto);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(evaluadorCantidadCuotas);
            evaluador.AgregarEvaluador(evaluadorAntiguedadLaboral);
            Assert.True(evaluador.EsValida(unaSolicitud));
        }
        [Fact]
        public void TestEvaluadorCompuestoEsValidaFuncionaPorFalse()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            EvaluadorAntiguedadLaboral evaluadorAntiguedadLaboral = new EvaluadorAntiguedadLaboral(6);
            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(5000);
            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(6000);
            EvaluadorCantidadCuotas evaluadorCantidadCuotas = new EvaluadorCantidadCuotas(18);
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 20, unCliente);
            EvaluadorCompuesto evaluador = new EvaluadorCompuesto();
            evaluador.AgregarEvaluador(evaluadorMonto);
            evaluador.AgregarEvaluador(evaluadorEdad);
            evaluador.AgregarEvaluador(evaluadorSueldo);
            evaluador.AgregarEvaluador(evaluadorCantidadCuotas);
            evaluador.AgregarEvaluador(evaluadorAntiguedadLaboral);
            Assert.False(evaluador.EsValida(unaSolicitud));
        }


    }
}
