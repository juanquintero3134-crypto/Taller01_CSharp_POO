using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaTechApp
{
    public class Laptop:Producto,IReportable
    {
        public string MarcaGPU { get; set; }
        public int RamGB { get; set; }

        public Laptop(int id, string nombre, double precio, int stock, string marcaGPU, int ramGB)
            : base(id, nombre, precio, stock)
        {
            MarcaGPU = marcaGPU;
            RamGB = ramGB;
        }

        public override double CalcularPrecioFinal()
        {
            if (RamGB >= 16)
                return Precio * 0.92; // 8% descuento
            return Precio;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"GPU: {MarcaGPU} | RAM: {RamGB}GB | Precio Final: ${CalcularPrecioFinal():F2}");
        }

        public string GenerarReporte()
        {
            return $"[Laptop] {Nombre} - Precio Final: ${CalcularPrecioFinal():F2}";
        }
    }
}

