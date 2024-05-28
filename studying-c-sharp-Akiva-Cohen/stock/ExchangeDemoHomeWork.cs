using studying_c_sharp_Akiva_Cohen.stock;

namespace studying_c_sharp_Akiva_Cohen.stock
{
    public class ExchangeDemoHomeWork
    {
        public static void RunDemo()
        {
            Stock apple = new Stock("Apple Inc.", "AAPL", "Technology", "NASDAQ");

            Stock tesla = new Stock("Tesla Inc.", "TSLA", "Automotive", "NASDAQ");

            Stock cocaCola = new Stock("Coca-Cola Co.", "COKE", "Beverages", "NYSE");

            // Data for the date 05/21/2024
            // These values would typically be fetched from an API, but are hardcoded here for the demonstration.

            // Apple
            apple.StartDay(125.00);
            apple.SetPrice(128.50); // highest price during the day
            apple.DisplayPrice();
            apple.PrintChangesPercentage();
            apple.FinishDay(127.00);
            apple.PrintChangesPercentage();

            Console.WriteLine();

            // Tesla
            tesla.StartDay(650.00);
            tesla.SetPrice(675.00); // highest price during the day
            tesla.DisplayPrice();
            tesla.PrintChangesPercentage();
            tesla.FinishDay(660.00);
            tesla.PrintChangesPercentage();

            Console.WriteLine();

            // Coca-Cola
            cocaCola.StartDay(55.00);
            cocaCola.SetPrice(57.00); // highest price during the day
            cocaCola.DisplayPrice();
            cocaCola.PrintChangesPercentage();
            cocaCola.FinishDay(56.50);
            cocaCola.PrintChangesPercentage();
        }
    }
}
