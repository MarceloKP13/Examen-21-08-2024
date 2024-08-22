using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSupermercado
{
    public class GestionSupermercado
    {
        private Dictionary<string, Product> productos = new Dictionary<string, Product>();
        // Introducir un nuevo producto
        public void addProducto(string codigo, string nombre, double precio)
        {
            if (productos.ContainsKey(codigo))
            {
                Console.WriteLine("Error: Ya existe un producto con ese código");
            }
            else
            {
                Product nuevoProduct = new Product(codigo, nombre, precio);
                productos.Add(codigo, nuevoProduct);
            }
        }

        //Eliminar producto
        public void deleteProducto(string codigo)
        {
            if (productos.Remove(codigo))
            {
                Console.WriteLine("Producto eliminado");
            }
            else
            {
                Console.WriteLine("Error: No se encontró el producto");
            }
        }

        //Consultar
        public void consultarProducto(string codigo)
        {
            if (productos.TryGetValue(codigo, out Product product))
            {
                Console.WriteLine($"Nombre: {product.Nombre}, Precio: {product.Precio:C}");
            }
            else
            {
                Console.WriteLine("Error: No se encontró el producto");
            }
        }
        //Modificar Precio
        public void modificarPrecio(string codigo, double nuevoPrecio)
        {
            if (productos.TryGetValue(codigo, out Product product))
            {
                product.Precio = nuevoPrecio;
                product.Descuento = product.calcularDescuento();
                Console.WriteLine("Precio modificado con éxito.");
            }
            else
            {
                Console.WriteLine("Error: No se encontró el producto.");
            }
        }
        // Mostrar productos menores de 30$
        public void productosDe30()
        {
            var productosMenoresDe30 = productos.Values.Where(p => p.Precio < 30);
            foreach (var producto in productosMenoresDe30)
            {
                producto.mostrarInfo();
            }
        }
        // Mostrar todos los productos con un precio mayor a 60$
        public void productosMasDe60()
        {
            var productosMayoresDe60 = productos.Values.Where(p => p.Precio > 60);
            foreach(var producto in productosMayoresDe60)
            {
                producto.mostrarInfo();
            }
        }
        public bool productoExiste(string codigo)
        {
            return productos.ContainsKey(codigo);
        }
    }
}
