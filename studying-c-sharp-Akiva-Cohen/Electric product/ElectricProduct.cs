using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Akiva_Cohen.Electric_product
{
    public class ElectricProduct
    {
        private string brand;
        private string model;
        private decimal price;
        private int powerConsumption;// in Watts

        public ElectricProduct() { }
        public ElectricProduct(string brand, string model, decimal price, int powerConsumption)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.powerConsumption = powerConsumption;
        }

        public string GetBrand() { return brand; }
        public string GetModel() { return model; }
        public decimal GetPrice() { return price; }
        public int GetPowerConsumption() { return powerConsumption; }

        public void SetBrand(string brand) { this.brand = brand; }
        public void SetModel(string model) { this.model = model; }
        public void SetPrice(decimal price) { this.price = price; }
        public void SetPowerConsumption(int powerConsumption) { this.powerConsumption = powerConsumption; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"brand: {brand}");
            Console.WriteLine($"model: {model}");
            Console.WriteLine($"price: {price}");
            Console.WriteLine($"Power Consumption: {powerConsumption}W");
        }
    }
}
