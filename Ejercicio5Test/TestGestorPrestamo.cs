using System;
using System.Collections.Generic;
using System.Text;
using Ejercicio5;
using Xunit;
namespace Ejercicio5Test
{
    public class TestGestorPrestamo
    {
        [Fact]
        public void testGestorPrestamoFuncionaTrue()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            GestorPrestamos unGestor = new GestorPrestamos();
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(6000, 12, unCliente);
            Assert.True(unGestor.EsValida(unaSolicitud));
        }
            [Fact]
            public void testGestorPrestamoFuncionaTruePremium()
            {
                Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
                Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
                unCliente.TipoCliente = TipoCliente.ClientePremium;
                GestorPrestamos unGestor = new GestorPrestamos();
                SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(200000, 60, unCliente);
                Assert.True(unGestor.EsValida(unaSolicitud));
            }


            [Fact]
        public void testGestorPrestamoFuncionaFalse()
        {
            Empleo unEmpleo = new Empleo(5000, new DateTime(2005, 05, 15));
            Cliente unCliente = new Cliente("Juan", "Martinez", new DateTime(1998, 07, 15), unEmpleo);
            GestorPrestamos unGestor = new GestorPrestamos();
            SolicitudPrestamo unaSolicitud = new SolicitudPrestamo(26000, 12, unCliente);
            Assert.False(unGestor.EsValida(unaSolicitud));
        }
    }
}
