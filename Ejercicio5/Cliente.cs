using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    public class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private TipoCliente iTipoCliente;
        private Empleo iEmpleo;

        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iApellido = pApellido;
            this.iNombre = pNombre;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iTipoCliente = 0;
            this.iEmpleo = pEmpleo;
        }

        public string Nombre { get { return this.iNombre; } }
        public string Apellido {get { return this.iApellido; } }
        public DateTime FechaNacimiento {get { return this.iFechaNacimiento; } }
        public Empleo Empleo {get{return this.iEmpleo;}}
        public TipoCliente TipoCliente {get{return this.iTipoCliente;}set {this.iTipoCliente = value;}}


    }
}
