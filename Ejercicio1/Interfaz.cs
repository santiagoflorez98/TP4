using System;

namespace Ejercicio1
{
    public class Interfaz
    {
        public static void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Inserte dividendo:");
                if (!Int32.TryParse(Console.ReadLine(), out int dividendo))
                { throw new Exception("El numero ingresado debe ser un entero"); };
                Console.WriteLine("Inserte Divisor:");
                if (!Int32.TryParse(Console.ReadLine(), out int divisor))
                { throw new Exception("El numero ingresado debe ser un entero"); }
                Console.WriteLine("El resultado es {0}", new Facade().Dividir(dividendo, divisor));
                Console.ReadKey();
            }
            catch (DivisionPorCeroException ex)
            {
                Console.WriteLine("\nMessage  ---\n{0}", ex.Message);
                Console.WriteLine("\nStackTrace ---\n{0}", ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error generico de la aplicacion");
                Console.WriteLine("\nMessage  ---\n{0}", ex.Message);
                Console.WriteLine("\nStackTrace ---\n{0}", ex.StackTrace);
            }

        }

    }
}
