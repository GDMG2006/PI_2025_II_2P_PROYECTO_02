using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_II_2P_PROYECTO_02.clases_06
{
    internal class _03_Clase_Factura
    {
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public _02_Clase_Cliente Cliente { get; set; }
        public decimal SubTotal { get; set; } // Nuevo: mejor separar subtotal y total
        public decimal Total { get; private set; } // Ahora es calculado
        public decimal IVA { get; set; }
        public decimal Descuento { get; set; }
        public string Estado { get; set; }

        // Constructor mejorado
        public _03_Clase_Factura(int numeroFactura, DateTime fecha, _02_Clase_Cliente cliente,
            decimal subTotal, decimal iva, decimal descuento, string estado)
        {
            NumeroFactura = numeroFactura; // Corregido: asignación correcta
            Fecha = fecha;
            Cliente = cliente;
            SubTotal = subTotal;
            IVA = iva;
            Descuento = descuento;
            Estado = estado;
            CalcularTotal(); // Calcula el total al crear la factura
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"\n=== Factura N° {NumeroFactura} ===");
            Console.WriteLine($"Fecha: {Fecha.ToShortDateString()}");
            Console.WriteLine("\nDatos del Cliente:");
            Cliente.MostrarInfo(); // Llama al método MostrarInfo del cliente
            Console.WriteLine("\nDetalles de Factura:");
            Console.WriteLine($"Subtotal: {SubTotal:C}");
            Console.WriteLine($"IVA ({IVA * 100}%): {SubTotal * IVA:C}");
            Console.WriteLine($"Descuento ({Descuento}%): {SubTotal * (Descuento / 100):C}");
            Console.WriteLine($"Total: {Total:C}");
            Console.WriteLine($"Estado: {Estado}");
        }

        public void AplicarDescuento(decimal nuevoDescuento)
        {
            if (nuevoDescuento < 0 || nuevoDescuento > 100)
            {
                Console.WriteLine("Error: El descuento debe estar entre 0% y 100%");
                return;
            }

            Descuento = nuevoDescuento;
            CalcularTotal();
            Console.WriteLine($"Descuento aplicado. Nuevo total: {Total:C}");
        }

        private void CalcularTotal()
        {
            decimal montoDescuento = SubTotal * (Descuento / 100);
            decimal montoIVA = SubTotal * IVA;
            Total = SubTotal - montoDescuento + montoIVA;
        }

        public void CambiarEstado(string nuevoEstado)
        {
            string[] estadosValidos = { "Pagada", "Pendiente", "Cancelada", "Vencida" };

            if (Array.Exists(estadosValidos, e => e.Equals(nuevoEstado, StringComparison.OrdinalIgnoreCase)))
            {
                Estado = nuevoEstado;
                Console.WriteLine($"Estado cambiado a: {Estado}");
            }
            else
            {
                Console.WriteLine("Estado no válido. Use: Pagada, Pendiente, Cancelada o Vencida");
            }
        }
    }
}