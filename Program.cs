using System;
using TiendaTechApp;

class Program
{
    static void Main()
    {
        TiendaTech tienda = new TiendaTech();
        int opcion;

        do
        {
            Console.WriteLine("\n===== TIENDATECH - GESTIÓN DE INVENTARIO =====");
            Console.WriteLine("1. Registrar Laptop");
            Console.WriteLine("2. Registrar Teléfono");
            Console.WriteLine("3. Registrar Accesorio");
            Console.WriteLine("4. Listar todos los productos");
            Console.WriteLine("5. Buscar producto por ID");
            Console.WriteLine("6. Ver total del inventario ($)");
            Console.WriteLine("7. Generar reporte completo");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            try
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("ID: ");
                        int idL = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        string nombreL = Console.ReadLine();
                        Console.Write("Precio: ");
                        double precioL = double.Parse(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stockL = int.Parse(Console.ReadLine());
                        Console.Write("Marca GPU: ");
                        string gpu = Console.ReadLine();
                        Console.Write("RAM (GB): ");
                        int ram = int.Parse(Console.ReadLine());

                        tienda.AgregarProducto(new Laptop(idL, nombreL, precioL, stockL, gpu, ram));
                        break;

                    case 2:
                        Console.Write("ID: ");
                        int idT = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        string nombreT = Console.ReadLine();
                        Console.Write("Precio: ");
                        double precioT = double.Parse(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stockT = int.Parse(Console.ReadLine());
                        Console.Write("Sistema Operativo: ");
                        string so = Console.ReadLine();
                        Console.Write("Cámara MP: ");
                        int camara = int.Parse(Console.ReadLine());

                        tienda.AgregarProducto(new Telefono(idT, nombreT, precioT, stockT, so, camara));
                        break;

                    case 3:
                        Console.Write("ID: ");
                        int idA = int.Parse(Console.ReadLine());
                        Console.Write("Nombre: ");
                        string nombreA = Console.ReadLine();
                        Console.Write("Precio: ");
                        double precioA = double.Parse(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stockA = int.Parse(Console.ReadLine());
                        Console.Write("Categoría: ");
                        string categoria = Console.ReadLine();
                        Console.Write("¿Es Gaming? (true/false): ");
                        bool gaming = bool.Parse(Console.ReadLine());

                        tienda.AgregarProducto(new Accesorio(idA, nombreA, precioA, stockA, categoria, gaming));
                        break;

                    case 4:
                        tienda.ListarProductos();
                        break;

                    case 5:
                        Console.Write("Ingrese ID: ");
                        int buscarId = int.Parse(Console.ReadLine());
                        var producto = tienda.BuscarPorId(buscarId);
                        if (producto != null)
                            producto.MostrarInfo();
                        else
                            Console.WriteLine("Producto no encontrado.");
                        break;

                    case 6:
                        Console.WriteLine($"Total Inventario: ${tienda.CalcularTotalInventario():F2}");
                        break;

                    case 7:
                        tienda.GenerarReporteTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        } while (opcion != 0);
    }
}
