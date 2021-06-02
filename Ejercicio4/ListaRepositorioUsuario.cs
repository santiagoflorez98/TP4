using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejercicio3;

namespace Ejercicio4
{
    public class ListaRepositorioUsuario : IRepositorioUsuarios
    {
        private List<Usuario> iRepositorio;
        public ListaRepositorioUsuario()
        {
           
            this.iRepositorio = new List<Usuario>();
        }
        public List<Usuario> Repositorio
        { get { return this.iRepositorio; } }

        public void Agregar(Usuario pUsuario)
        { if (!this.Repositorio.Contains(pUsuario))
                {
                this.Repositorio.Add(pUsuario); } }
        public void Actualizar(Usuario pUsuario)
        { if (this.Repositorio.Contains(pUsuario));
            { int indiceUsuario = this.Repositorio.IndexOf(pUsuario);
                this.Repositorio[indiceUsuario].CorreoElectronico = pUsuario.CorreoElectronico;
                this.Repositorio[indiceUsuario].NombreCompleto = pUsuario.NombreCompleto;
            }
        }
        public void Eliminar(string pCodigo)
        {
            Usuario usuarioEliminar = this.Repositorio.Find(Usuario => Usuario.Codigo == pCodigo);
            this.Repositorio.Remove(usuarioEliminar);
        }
        public IList<Usuario> ObtenerTodos()
        { List<Usuario> listaADevolver = this.Repositorio.ToList<Usuario>();
            return listaADevolver;
        }
        public Usuario ObtenerPorCodigo(string pCodigo)
        { return this.Repositorio.Find(Usuario => Usuario.Codigo == pCodigo); }
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> listaADevolver = this.Repositorio.ToList<Usuario>();
            listaADevolver.Sort(pComparador);
            return listaADevolver;
        }

        public IList<Usuario> ObtenerPorSubcadenaDelNombre(string pSubcadena)
        {
            List<Usuario> listaADevolver = new List<Usuario>();
            for (int i = 0; i < this.Repositorio.Count(); i++)
            {
                if (this.iRepositorio[i].NombreCompleto.Contains(pSubcadena))
                { listaADevolver.Add(this.iRepositorio[i]); }
            }
            return listaADevolver;
        }



    }
}
