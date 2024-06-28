using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product.products
{
    public class PlayStation : GameConsole
    {
        public string exclusiveGames { get; set; }

        public PlayStation() { }
        public PlayStation(string brand, string model, decimal price, int powerConsumption, int storageCapacity, string supportedResolutions, string exclusiveGames)
            : base(brand, model, price, powerConsumption, storageCapacity, supportedResolutions)
        {
            this.exclusiveGames = exclusiveGames;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Exclusive Games: {exclusiveGames}");
        }
    }

}
