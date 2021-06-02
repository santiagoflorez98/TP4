using System;

namespace Ejercicio2
{
    public class Interfaz
    {
        int opc;
        Facade unaFachada = new Facade();
        /// <summary>
        /// Llama a la interfaz del programa del Ejercicio2
        /// </summary>
        /// <returns>La interfaz en consola</returns>
        public void MenuPrincipal()
        {
            try
            {
                Console.WriteLine("Sistema de gestión de cuentas bancaria");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1- Crear cuenta");
                Console.WriteLine("2- Mostrar Saldo Cuenta");
                Console.WriteLine("3- Acreditar Saldo");
                Console.WriteLine("4- Debitar Saldo ");
                Console.WriteLine("5- Transferir Saldo ");
                Console.WriteLine("0- Salir ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese nombre de titular y DNI: ");
                            Console.WriteLine("Nombre titular:");
                            string titular = Console.ReadLine();
                            Console.WriteLine("DNI:");
                            string dni = Console.ReadLine();
                            unaFachada.crearCuentaUnificada(dni, titular);
                            Console.WriteLine("Cuenta creada con exito");
                            Console.ReadLine();
                            Console.Clear();
                            this.MenuPrincipal();
                            break;
                        }
                    case 2:
                        {
                            int aux;
                            Console.Clear();
                            Console.WriteLine("Mostrar Saldo Cuenta");
                            Console.WriteLine("Ingrese DNI de la cuenta:");
                            string dni = Console.ReadLine();
                            Console.WriteLine("Elija la cuenta:");
                            Console.WriteLine("1- Cuenta en pesos");
                            Console.WriteLine("2- Cuenta en dolares");
                            aux = Convert.ToInt32(Console.ReadLine());
                            if (aux == 1)
                            { Console.WriteLine("Saldo de la cuenta: " + unaFachada.getSaldoCuenta(dni, "Pesos")); }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Saldo de la cuenta: " + unaFachada.getSaldoCuenta(dni, "Dolar"));
                            }
                            Console.ReadLine();
                            Console.Clear();
                            this.MenuPrincipal();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese DNI de la cuenta:");
                            string dni = Console.ReadLine();
                            Console.WriteLine("Elija la cuenta");
                            Console.WriteLine("1- Cuenta en pesos");
                            Console.WriteLine("2- Cuenta en dolares");
                            int aux = Convert.ToInt32(Console.ReadLine());
                            if (aux == 1)
                            {
                                Console.WriteLine("Ingrese el monto a acreditar en pesos");
                                int pCantidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Monto acreditado. Nuevo Saldo: " + unaFachada.acreditarCuentaPesos(dni, pCantidad));
                            }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Ingrese el monto a acreditar en dolares");
                                int pCantidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Monto acreditado. Nuevo Saldo: " + unaFachada.acreditarCuentaDolares(dni, pCantidad));
                            }
                            Console.ReadLine();
                            Console.Clear();
                            this.MenuPrincipal();
                            break;

                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese DNI de la cuenta:");
                            string dni = Console.ReadLine();
                            Console.WriteLine("Elija el movimiento que quiere hacer");
                            Console.WriteLine("1- Transferir de dolares a pesos");
                            Console.WriteLine("2- Transferir de pesos a dolares");
                            int aux = Convert.ToInt32(Console.ReadLine());
                            if (aux == 1)
                            {
                                Console.WriteLine("Ingrese el monto a transferir en dolares");
                                double pCantidad;
                                if (Double.TryParse(Console.ReadLine(), out pCantidad))

                                {
                                    unaFachada.transferirDolaresAPesos(dni, pCantidad);
                                    Console.WriteLine("Transferencia realizada con exito.");
                                    Console.WriteLine("Nuevo saldo en cuenta en pesos: " + unaFachada.getSaldoCuenta(dni, "Pesos"));
                                    Console.WriteLine("Nuevo saldo cuenta en dolares: " + unaFachada.getSaldoCuenta(dni, "Dolar"));
                                }
                                else { throw new Exception("El monto debe ser un numero real"); }
                            }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Ingrese el monto a transferir en pesos");
                                double pCantidad;
                                if (Double.TryParse(Console.ReadLine(), out pCantidad))

                                {
                                    unaFachada.transferirPesosADolares(dni, pCantidad);
                                    Console.WriteLine("Transferencia realizada con exito.");
                                    Console.WriteLine("Nuevo saldo en cuenta en pesos: " + unaFachada.getSaldoCuenta(dni, "Pesos"));
                                    Console.WriteLine("Nuevo saldo cuenta en dolares: " + unaFachada.getSaldoCuenta(dni, "Dolar"));
                                }
                                else { throw new Exception("El monto debe ser un numero real"); }
                            }
                            Console.ReadLine();
                            Console.Clear();
                            this.MenuPrincipal();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese DNI de la cuenta:");
                            string dni = Console.ReadLine();
                            Console.WriteLine("Elija la cuenta");
                            Console.WriteLine("1- Cuenta en pesos");
                            Console.WriteLine("2- Cuenta en dolares");
                            int aux = Convert.ToInt32(Console.ReadLine());
                            if (aux == 1)
                            {
                                Console.WriteLine("Ingrese el monto a debitar en pesos");
                                double pCantidad;
                                if (!Double.TryParse(Console.ReadLine(), out pCantidad))
                                { throw new Exception("La cantidad debe ser un numero "); }
                                else
                                { Console.WriteLine("Monto debitado con exito. Nuevo Saldo: " + unaFachada.debitarCuentaPesos(dni, pCantidad)); }
                            }
                            else if (aux == 2)
                            {
                                Console.WriteLine("Ingrese el monto a debitar en dolares");
                                double pCantidad;
                                if (!Double.TryParse(Console.ReadLine(), out pCantidad))
                                { throw new Exception("La cantidad debe ser un numero "); }
                                else
                                { Console.WriteLine("Monto debitado con exito. Nuevo Saldo: " + unaFachada.debitarCuentaDolares(dni, pCantidad)); }
                            }
                            Console.ReadLine();
                            Console.Clear();
                            this.MenuPrincipal();
                            break;
                        }
                }
            }
            catch (CuentaNoEncontradaException ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                Console.WriteLine("\nStackTrace ---\n{0}", ex.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                Console.WriteLine("\nStackTrace ---\n{0}", ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error generico");
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                Console.WriteLine("\nStackTrace ---\n{0}", ex.StackTrace);
            }

        }

    }
}
