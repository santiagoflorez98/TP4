using System;

namespace Ejercicio3
{
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo, iNombreCompleto, iCorreoElectronico;

        public Usuario(string pCodigo,string pNombre,string pCorreoElectronico)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombre;
            this.iCorreoElectronico = pCorreoElectronico;
        }
        public string Codigo
        {
            get
            { return this.iCodigo; }
            set
            { this.iCodigo = value; }
        }
        public string NombreCompleto
        {
            get
            { return this.iNombreCompleto; }
            set
            { this.iNombreCompleto = value; }
        }
        public string CorreoElectronico
        {
            get
            { return this.iCorreoElectronico; }
            set
            { this.iCorreoElectronico = value; }
        }

        public int CompareTo(Usuario other)
        {
            if (object.ReferenceEquals(other, null))
            { return 1; }
                return this.Codigo.CompareTo(other.Codigo);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj as Usuario);
        }
        public bool Equals(Usuario other)
        { return other != null && iCodigo == other.iCodigo; }

        public override int GetHashCode()
        {
            return HashCode.Combine(iCodigo);
        }

    }
}
