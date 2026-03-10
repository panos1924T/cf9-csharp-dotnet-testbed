namespace ProductsVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double VAT = 0.24;
            double price = 0.0;
            double priceVat = 0.0;

            Console.WriteLine("Please type the price you want to calculate the VAT from: ");

            if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
                Console.WriteLine("Invalid input! ");

            priceVat = price * VAT;
            price = price + priceVat;

            Console.WriteLine($"The price of: {price} has a VAT of: {priceVat}");
            
        }
    }
}
