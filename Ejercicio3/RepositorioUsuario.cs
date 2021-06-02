using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3
{
   public class RepositorioUsuario : IRepositorioUsuarios
    {
        private IDictionary<string, Usuario> iRepositorio;

        public RepositorioUsuario()
        { iRepositorio = new SortedDictionary<string, Usuario>(); }

        public IDictionary<string, Usuario> Repositorio
        {get { return this.iRepositorio; } }

        public void Agregar(Usuario pUsuario)
        { iRepositorio.Add(pUsuario.Codigo, pUsuario); }

        public void Actualizar(Usuario pUsuario)
        { if (iRepositorio.ContainsKey(pUsuario.Codigo))
            { iRepositorio.Remove(pUsuario.Codigo);
                iRepositorio.Add(pUsuario.Codigo, pUsuario);
            }
        }
        public void Eliminar(string pString)
        { iRepositorio.Remove(pString); }
        public IList<Usuario> ObtenerTodos()
        {
           List<Usuario> listaUsuarios = iRepositorio.Values.ToList<Usuario>();
            return listaUsuarios;
        }
        public Usuario ObtenerPorCodigo(string pString)
        { Usuario usuarioBuscado;
            if (!iRepositorio.TryGetValue(pString, out usuarioBuscado))
            { throw new NotImplementedException("El usuario buscado no existe"); }
            return usuarioBuscado;
        }
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        { List<Usuario> listaUsuarios = iRepositorio.Values.ToList<Usuario>();
            listaUsuarios.Sort(pComparador);
            return listaUsuarios;
        }

    }
}
