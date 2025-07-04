using PI_2025_II_2P_PROYECTO_02.clases_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2025_II_2P_PROYECTO_02
{
    internal class Program
    {


        static void Main(string[] args)
        {
            try
            {
                _01_Clase_Videojuego juego = new _01_Clase_Videojuego
                {
                    Titulo = "The Legend of Zelda",
                    Genero = "Aventura",
                    Precio = 59.99m,
                    ClasificacionEdad = "E",
                    Plataforma = "Nintendo Switch",
                    Stock = 10,
                    CodigoJuego = "ZELDA123"
                };

                juego.MostrarInfo();

                Console.Write("Ingrese porcentaje de descuento: ");
                double descuento = double.Parse(Console.ReadLine());

                juego.AplicarDescuento(descuento);

                if (juego.HayStock())
                    Console.WriteLine("Sin stock.");

                else
                    Console.WriteLine("¡El juego está disponible!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato: Ingrese un número válido.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error de rango: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }


            //------------------------
            // USO DIFERETE DE CLASE CLIENTE
            //------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            // Crear un cliente usando el constructor con parámetros
            var cliente1 = new _02_Clase_Cliente(
                    "María",
                    "González",
                    "maria@ejemplo.com",
                    "5551234567",
                    "Av. Principal 123",
                    28,
                    1001);

                // Mostrar información del cliente
                Console.WriteLine("=== Información del cliente ===");
                cliente1.MostrarInfo();

                // Validar datos del cliente
                Console.WriteLine("\n=== Validaciones ===");
                Console.WriteLine($"Correo válido: {cliente1.ValidarCorreo()}");
                Console.WriteLine($"Teléfono válido: {cliente1.ValidarTelefono()}");
                Console.WriteLine($"Mayor de edad: {cliente1.EsMayorDeEdad()}");

                // Crear un cliente usando el constructor vacío y luego asignar valores
                var cliente2 = new _02_Clase_Cliente();
                cliente2.Nombre = "Carlos";
                cliente2.Apellido = "López";
                cliente2.Edad = 19;


            //
            //cambio de clases factura
            //

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            {
                // Crear un cliente primero
                var cliente = new _02_Clase_Cliente(
                     "María",
                    "González",
                    "maria@ejemplo.com",
                    "5551234567",
                    "Av. Principal 123",
                    28,
                    1001);

                // Crear una factura
                var factura = new _03_Clase_Factura(
                    10001,
                    DateTime.Now,
                    cliente,
                    1000.00m,  // Subtotal
                    0.16m,     // IVA (16%)
                    10.0m,     // Descuento (10%)
                    "Pendiente");

                // Mostrar información
                factura.MostrarInfo();

                // Aplicar nuevo descuento
                factura.AplicarDescuento(15.0m); // 15% de descuento

                // Cambiar estado
                factura.CambiarEstado("Pagada");
            }
        }


    }
    
}


           
        
    
