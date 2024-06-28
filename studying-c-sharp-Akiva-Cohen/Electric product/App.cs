using studying_c_sharp_Akiva_Cohen.Electric_product.products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product
{
    public class App
    {
        public static void RunApp()
        {
            ElectricProduct[] electricProducts =
            {
                new ElectricProduct("Samsung", "QLED 8K", 2999.99m, 200), // סבא
                new Screen("Sony", "QLED 4K", 1999.99m, 200, 65, "7680x4320"), // אבא
                new TV("Muler", "QLED 8K", 2499.99m, 200, 50, "7680x4320", true, 4) // נכד
            };

            foreach (ElectricProduct product in electricProducts)
            {
                product.DisplayDetails();
                Console.WriteLine();
            }

            //Screen screen = (Screen)new ElectricProduct();
            Screen screen = new Screen();

            ElectricProduct electricProduct = (ElectricProduct) screen;

            if(screen is ElectricProduct) Console.WriteLine("screen is ElectricProduct");
            else Console.WriteLine("screen is not ElectricProduct");

            if (electricProduct is Screen) Console.WriteLine("electricProduct is Screen");
            else Console.WriteLine("electricProduct is not Screen");

            //TV myTV = new TV("Samsung", "QLED 8K", 2999.99m, 200, 65, "7680x4320", true, 4);
            //PlayStation myPlayStation = new PlayStation("Sony", "PlayStation 5", 499.99m, 200, 825, "4K, 1080p", "Spider-Man: Miles Morales");

            //myTV.DisplayDetails();
            //Console.WriteLine();
            //myPlayStation.DisplayDetails();
        }
    }
}
