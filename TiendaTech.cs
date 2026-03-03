using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaTechApp
{
    public class TiendaTech
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void ListarProductos()
        {
            foreach (var p in productos)
                p.MostrarInfo();
        }

        public Producto BuscarPorId(int id)
        {
            return productos.Find(p => p.Id == id);
        }

        public double CalcularTotalInventario()
        {
            double total = 0;
            foreach (var p in productos)
                total += p.Precio * p.Stock;

            return total;
        }

        public void GenerarReporteTodos()
        {
            foreach (var p in productos)
            {
                if (p is IReportable reportable)
                    Console.WriteLine(reportable.GenerarReporte());
            }
        }
    }
}

