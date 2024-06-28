using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product.products
{
    public class TV : Screen
    {
        public bool isSmartTV { get; set; }
        public int HDMIports { get; set; }

        public TV() { }
        public TV(string brand, string model, decimal price, int powerConsumption, int screenSize, string resolution, bool isSmartTV, int hdmiPorts)
            : base(brand, model, price, powerConsumption, screenSize, resolution)
        {
            this.isSmartTV = isSmartTV;
            this.HDMIports = hdmiPorts;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Smart TV: {(isSmartTV ? "Yes" : "No")}");
            Console.WriteLine($"HDMI Ports: {HDMIports}");
        }
    }

}
