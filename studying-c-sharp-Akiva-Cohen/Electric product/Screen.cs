using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product
{
    public class Screen : ElectricProduct
    {
        public int screenSize { get; set; } // in inches
        public string resolution { get; set; } // e.g., 1920x1080

        public Screen() { }
        public Screen(string brand, string model, decimal price, int powerConsumption, int screenSize, string resolution)
            : base(brand, model, price, powerConsumption)
        {
            this.screenSize = screenSize;
            this.resolution = resolution;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Screen Size: {screenSize}\"");
            Console.WriteLine($"resolution: {resolution}");
        }
    }

}
