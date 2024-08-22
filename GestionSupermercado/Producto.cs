using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSupermercado
{
    public interface Producto
    {
        void mostrarInfo();
        double calcularDescuento();
    }
}
