using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSupermercado
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de GestionSupermercado
            GestionSupermercado gestion = new GestionSupermercado();

            // Añadir productos iniciales
            gestion.addProducto("001", "Manzana", 0.99);
            gestion.addProducto("002", "Pan", 1.89);
            gestion.addProducto("003", "Shampoo", 7.99);
            gestion.addProducto("004", "Televisor", 249.99);
            gestion.addProducto("005", "Camiseta", 9.99);
            gestion.addProducto("006", "Reloj", 49.99);
            gestion.addProducto("007", "Bicicleta", 119.99);

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                // Mostrar productos actuales
                Console.WriteLine("Productos actuales:");
                gestion.productosDe30(); // Mostrar todos los productos menores de 30$
                gestion.productosMasDe60(); // Mostrar todos los productos mayores de 60$
                Console.WriteLine();

                // Mostrar menú de opciones
                Console.WriteLine("Gestión de Supermercado");
                Console.WriteLine("1. Añadir producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Consultar producto");
                Console.WriteLine("4. Modificar precio del producto");
                Console.WriteLine("5. Mostrar productos menores de 30$");
                Console.WriteLine("6. Mostrar productos mayores de 60$");
                Console.WriteLine("7. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Introduce el código del producto: ");
                        string codigoAñadir = Console.ReadLine();
                        if (gestion.productoExiste(codigoAñadir))
                        {
                            Console.WriteLine("Error: Ya existe un producto con ese código.");
                        }
                        else
                        {
                            Console.Write("Introduce el nombre del producto: ");
                            string nombreAñadir = Console.ReadLine();
                            Console.Write("Introduce el precio del producto: ");
                            double precioAñadir = double.Parse(Console.ReadLine());
                            gestion.addProducto(codigoAñadir, nombreAñadir, precioAñadir);
                            Console.WriteLine("Producto añadido con éxito.");
                        }
                        break;

                    case "2":
                        Console.Write("Introduce el código del producto a eliminar: ");
                        string codigoEliminar = Console.ReadLine();
                        gestion.deleteProducto(codigoEliminar);
                        break;

                    case "3":
                        Console.Write("Introduce el código del producto a consultar: ");
                        string codigoConsultar = Console.ReadLine();
                        gestion.consultarProducto(codigoConsultar);
                        break;

                    case "4":
                        Console.Write("Introduce el código del producto a modificar: ");
                        string codigoModificar = Console.ReadLine();
                        Console.Write("Introduce el nuevo precio del producto: ");
                        double nuevoPrecio = double.Parse(Console.ReadLine());
                        gestion.modificarPrecio(codigoModificar, nuevoPrecio);
                        break;

                    case "5":
                        Console.WriteLine("Productos menores de 30$:");
                        gestion.productosDe30();
                        break;

                    case "6":
                        Console.WriteLine("Productos mayores de 60$:");
                        gestion.productosMasDe60();
                        break;

                    case "7":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del menú.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
