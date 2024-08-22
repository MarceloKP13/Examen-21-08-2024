using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSupermercado
{
    public class Product : Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }

        // Constructor
        public Product(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Descuento = calcularDescuento();
        }

        // Calcula el descuento basado en el precio
        public double calcularDescuento()
        {
            if (Precio > 90)
                return 0.50;
            else if (Precio > 50)
                return 0.30;
            else if (Precio > 15)
                return 0.25;
            else
                return 0.05;
        }
        // Muestra la información del producto
        public void mostrarInfo()
        {
            Console.WriteLine($"{Codigo}, {Nombre}, {Precio:C}, {Descuento * 100}%");
        }
    }
}
