using System;

namespace studying_c_sharp_Akiva_Cohen.stock
{
    public class Stock
    {
        public string OfficialName;
        public double Price;
        public string Sign;
        public double StartingPrice;
        public double ClosingPrice;
        public string Industry;
        public string Exchange;
        public bool IsDayActive;

        public Stock(string officialName, string sign, string industry, string exchange)
        {
            OfficialName = officialName;
            Sign = sign;
            Industry = industry;
            Exchange = exchange;
        }

        public void StartDay(double price)
        {
            StartingPrice = price;
            Price = price;
            IsDayActive = true;
            Console.WriteLine($"Starting day for {OfficialName}. Price: {Price}");
        }

        public void FinishDay(double price)
        {
            ClosingPrice = price;
            Price = price;
            IsDayActive = false;
            Console.WriteLine($"Closing day for {OfficialName}. Price: {Price}");
        }

        public void SetPrice(double price)
        {
            if (IsDayActive)
            {
                Price = price;
                Console.WriteLine($"Setting price for {OfficialName} to {Price}");
            }
            else
            {
                Console.WriteLine($"Cannot set price for {OfficialName}. The day is not active.");
            }
        }

        public void PrintChangesPercentage()
        {
            if (!IsDayActive)
            {
                double percentChange = ((ClosingPrice - StartingPrice) / StartingPrice) * 100;
                Console.WriteLine($"Percent change for {OfficialName}: {percentChange}%");
            }
            else
            {
                Console.WriteLine($"Cannot calculate percent change for {OfficialName}. The day is still active.");
            }
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"{Sign}: {Price}");
        }
    }
}
