using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaTechApp
{
    public abstract class Producto

    {
        private int _id;
        private string _nombre;
        private double _precio;
        private int _stock;
        public Producto(int id, string nombre, double precio, int stock)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio > 0 ? precio : throw new ArgumentException("El precio debe ser positivo");
            _stock = stock >= 0 ? stock : 0;
        }

        public int Id { get => _id; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value > 0 ? value : _precio; }
        public int Stock { get => _stock; set => _stock = value >= 0 ? value : _stock; }

        public abstract double CalcularPrecioFinal();

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"ID: {Id} | Nombre: {Nombre} | Precio base: ${Precio:F2} | Stock: {Stock}");
        }
    }
}

