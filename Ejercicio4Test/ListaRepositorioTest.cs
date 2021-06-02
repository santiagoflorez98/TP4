using System;
using Xunit;
using Ejercicio4;
using Ejercicio3;
using System.Collections.Generic;

namespace Ejercicio4Test
{
    public class ListaRepositorioTest
    {
        [Fact]
        public void testeoContains()
        {
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            Assert.True(repositorio.Repositorio.Contains(unUsuario));

        }
        [Fact]
        public void testeoContainsSiNoExisteEnLaLista()
        {
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            Usuario otroUsuario = new Usuario("2", "pepa", "pepa@pepa.com");
            Assert.False(repositorio.Repositorio.Contains(otroUsuario));

        }
        [Fact]
        public void testeoEliminar()
        {
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            repositorio.Eliminar("3");
            Assert.False(repositorio.Repositorio.Contains(unUsuario));
        }
        [Fact]
        public void testeoListarTodo()
        {
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "asd", "asdasd"));
            repositorio.Agregar(new Usuario("4", "assd", "asddasd"));
            repositorio.Agregar(new Usuario("3", "asdd", "asdaasd"));
            Assert.Equal(4, repositorio.ObtenerTodos().Count);
        }

        [Fact]
        public void testeoObtenerPorCodigo()
        {
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "asd", "asdasd"));
            repositorio.Agregar(new Usuario("4", "assd", "asddasd"));
            repositorio.Agregar(new Usuario("3", "asdd", "asdaasd"));
            Assert.Equal(unUsuario, repositorio.ObtenerPorCodigo("3"));
        }

        [Fact]
        public void testeoListaOrdenadaPor()
        {
            IComparer<Usuario> comparadorPorNombre = new CompararPorNombreDescendente();
            Usuario unUsuario = new Usuario("3", "pepe", "pepe@pepe.com");
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(new Usuario("2", "asd", "asdasd"));
            repositorio.Agregar(new Usuario("4", "assd", "asddasd"));
            repositorio.Agregar(new Usuario("3", "asdd", "asdaasd"));
            Assert.Equal(unUsuario, repositorio.ObtenerOrdenadosPor(comparadorPorNombre)[3]);
        }

        [Fact]
        public void ActualizarFunciona()
        {
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "euan@aa.com");
            Usuario unUsuario2 = new Usuario("2", "julian", "euan@aa.com");
            repositorio.Agregar(unUsuario2);
            repositorio.Agregar(unUsuario);
            //Assert.Equal(1, repositorio.Repositorio.IndexOf(unUsuario));
            Usuario usuarioActualizado = new Usuario("1", "jose", "sdasda@aa.com");
            repositorio.Actualizar(usuarioActualizado);
            Assert.Equal("jose", repositorio.ObtenerPorCodigo("1").NombreCompleto);
        }

        [Fact]
        public void ObtenerPorSubcadenaNombreFunciona()
        {
            ListaRepositorioUsuario repositorio = new ListaRepositorioUsuario();
            Usuario unUsuario = new Usuario("1", "juan", "euan@aa.com");
            Usuario unUsuario2 = new Usuario("2", "julian", "euan@aa.com");
            Usuario unUsuario3 = new Usuario("3", "jan", "euan@aa.com");
            Usuario unUsuario4 = new Usuario("4", "julieta", "euan@aa.com");
            repositorio.Agregar(unUsuario);
            repositorio.Agregar(unUsuario2);
            repositorio.Agregar(unUsuario3);
            repositorio.Agregar(unUsuario4);
            Assert.Equal(3, repositorio.ObtenerPorSubcadenaDelNombre("ju").Count);


        }
    }
}
