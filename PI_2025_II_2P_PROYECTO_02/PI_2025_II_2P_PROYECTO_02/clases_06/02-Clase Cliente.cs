using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PI_2025_II_2P_PROYECTO_02.clases_06;

namespace PI_2025_II_2P_PROYECTO_02.clases_06
{
    internal class _02_Clase_Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int IDCliente { get; set; }
        // Constructor por defecto
        public _02_Clase_Cliente() { }
        // Constructor con parámetros
        public _02_Clase_Cliente(string nombre, string apellido, string correo, string telefono, string direccion, int edad, int idCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Edad = edad;
            IDCliente = idCliente;
        }
        // Método para mostrar información del cliente
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"ID Cliente: {IDCliente}");
        }
        // Método para actualizar información del cliente
        public void ActualizarInfo(string nombre, string apellido, string correo, string telefono, string direccion, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            Edad = edad;
        }
        // Método para validar la edad del cliente
        
           public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
        
        // Método para validar el correo electrónico
        public bool ValidarCorreo()
        {
            if (string.IsNullOrEmpty(Correo) || !Correo.Contains("@") || !Correo.Contains("."))
            {
                Console.WriteLine("Correo electrónico inválido.");
                return false;
            }
            return true;
        }
        // Método para validar el número de teléfono
        public bool ValidarTelefono()
        {
            if (string.IsNullOrEmpty(Telefono) || Telefono.Length < 10)
            {
                Console.WriteLine("Número de teléfono inválido. Debe tener al menos 10 dígitos.");
                return false;
            }
            return true;

        }
      
        


    }
}
