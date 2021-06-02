namespace Ejercicio2
{
    public class Moneda
    {
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        //CONSTRUCTOR
        public Moneda(string codigoISO, string nombre, string simbolo)
        {
            this.iCodigoISO = codigoISO;
            this.iNombre = nombre;
            this.iSimbolo = simbolo;
        }

        //PROPERTIES
        public string codigoISO { get { return iCodigoISO; } }
        public string nombre { get { return iNombre; } }
        public string simbolo { get { return iSimbolo; } }


    }
}
