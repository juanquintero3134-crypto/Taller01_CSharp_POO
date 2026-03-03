using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaTechApp
{
    public class Telefono:Producto,IReportable
    {
        public string SistemaOperativo { get; set; }
        public int CamaraMP { get; set; }

        public Telefono(int id, string nombre, double precio, int stock, string sistemaOperativo, int camaraMP)
            : base(id, nombre, precio, stock)
        {
            SistemaOperativo = sistemaOperativo;
            CamaraMP = camaraMP;
        }

        public override double CalcularPrecioFinal()
        {
            if (CamaraMP >= 50)
                return Precio * 0.95; // 5% descuento
            return Precio;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"SO: {SistemaOperativo} | Cámara: {CamaraMP}MP | Precio Final: ${CalcularPrecioFinal():F2}");
        }

        public string GenerarReporte()
        {
            return $"[Teléfono] {Nombre} - Precio Final: ${CalcularPrecioFinal():F2}";
        }
    }
}

