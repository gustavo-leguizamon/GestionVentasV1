using GL.GestionVentas.App;
using System;

namespace GL.GestionVentas.ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        public static void Init()
        {
            Console.Clear();

            while (true)
            {
                ShowOptions();

                switch (GetSelectedOption())
                {
                    case SelectedOption.RegisterSale:
                        break;
                    case SelectedOption.WatchSales:
                        break;
                    case SelectedOption.FindProduct:
                        break;
                    case SelectedOption.RegisterClient:
                        break;
                    case SelectedOption.Invalid:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            
        }

        public static SelectedOption GetSelectedOption()
        {
            int selectedOption = 0;
            string option = Console.ReadLine();
            int.TryParse(option, out selectedOption);
            return (SelectedOption)selectedOption;
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

        public static void RegisterClient()
        {

        }
    }
}
