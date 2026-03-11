namespace RentACar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double DAILYCOST = 25;
            const double PERKMCOST = 0.15;
            const double VAT = 0.24;

            double totalCost = 0;
            double totalCostWithVat = 0;

            double daysRent = 0;
            double kmMade = 0;

            Console.WriteLine("Please type the days you rented: ");

            if(!double.TryParse(Console.ReadLine(), out daysRent) || daysRent < 0)
            {
                Console.WriteLine("Invalid input! ");
                return;
            }

            Console.WriteLine("Now, type the kilometers you made due these days: ");

            if(!double.TryParse(Console.ReadLine(), out kmMade) || kmMade < 0)
            {
                Console.WriteLine("Invalid input! ");
                return;
            }

            totalCost = (kmMade * PERKMCOST) + (daysRent * DAILYCOST);
            totalCostWithVat = (totalCost * VAT) + totalCost;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"{"Price owed without VAT: ", -20} {totalCost:N2} \u20AC");
            Console.WriteLine($"{"Total price owed, VAT included: ", -20} {totalCostWithVat:N2} \u20AC");
        }
    }
}
