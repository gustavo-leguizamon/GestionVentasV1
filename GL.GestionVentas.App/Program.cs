using System;

namespace GL.GestionVentas.ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ShowOptions();

        }

        public string GetMessage()
        {
            return Console.ReadLine();
        }

        public static void ShowOptions()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1) Registrar venta");
            Console.WriteLine("2) Ver reporte de ventas del día");
            Console.WriteLine("3) Búsqueda de productos");
            Console.WriteLine("4) Registrar nuevo cliente");
        }

        public static void RegisterSale()
        {

        }
    }
}
