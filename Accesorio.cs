using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaTechApp
{
    public class Accesorio:Producto,IReportable
    {
        public string Categoria { get; set; }
        public bool EsGaming { get; set; }

        public Accesorio(int id, string nombre, double precio, int stock, string categoria, bool esGaming)
            : base(id, nombre, precio, stock)
        {
            Categoria = categoria;
            EsGaming = esGaming;
        }

        public override double CalcularPrecioFinal()
        {
            if (EsGaming)
                return Precio * 0.88; // 12% descuento
            return Precio;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Categoría: {Categoria} | Gaming: {EsGaming} | Precio Final: ${CalcularPrecioFinal():F2}");
        }

        public string GenerarReporte()
        {
            return $"[Accesorio] {Nombre} - Precio Final: ${CalcularPrecioFinal():F2}";
        }
    }
}

