using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product
{
    public class Keyboard : ElectricProduct
    {
        public string keySwitchType;
        public string KeySwitchType { get => keySwitchType; set => this.keySwitchType = value; } // e.g., "Mechanical", "Membrane"
        public bool isWireless { get; set; }

        public Keyboard() { }
        public Keyboard(string brand, string model, decimal price, int powerConsumption, string keySwitchType, bool isWireless)
            : base(brand, model, price, powerConsumption)
        {
            this.keySwitchType = keySwitchType;
            this.isWireless = isWireless;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Key Switch Type: {keySwitchType}");
            Console.WriteLine($"Wireless: {(isWireless ? "Yes" : "No")}");
        }
    }

}
