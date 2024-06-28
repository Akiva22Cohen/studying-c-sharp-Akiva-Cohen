using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product
{
    public class GameConsole : ElectricProduct
    {
        public int storageCapacity { get; set; } // in GB
        public string supportedResolutions { get; set; } // e.g., "4K, 1080p"

        public GameConsole() { }
        public GameConsole(string brand, string model, decimal price, int powerConsumption, int storageCapacity, string supportedResolutions)
            : base(brand, model, price, powerConsumption)
        {
            this.storageCapacity = storageCapacity;
            this.supportedResolutions = supportedResolutions;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Storage Capacity: {storageCapacity}GB");
            Console.WriteLine($"Supported Resolutions: {supportedResolutions}");
        }
    }

}
