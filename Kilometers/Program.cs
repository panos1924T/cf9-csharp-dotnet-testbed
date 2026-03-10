namespace Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double METERS_PER_KILOMETER = 1000.0;
            const double MILES_PER_KILOMETER = 0.621371;
            const double CENTIMETERS_PER_KILOMETER = 100000.0;

            double kilometers = 0.0;
            double meters = 0.0;
            double centimeters = 0.0;
            double miles = 0.0;


            Console.WriteLine("Please give how many kilometers you want to convert: ");

            if (!double.TryParse(Console.ReadLine(), out kilometers) || kilometers < 0)
            {
                Console.WriteLine("Invalid number! ");
                return;
            }

            meters = kilometers * METERS_PER_KILOMETER;
            centimeters = kilometers * CENTIMETERS_PER_KILOMETER;
            miles = kilometers * MILES_PER_KILOMETER;

            Console.WriteLine($"Kilometers: {kilometers}");
            Console.WriteLine($"Meters: {meters}");
            Console.WriteLine($"Centimeters: {centimeters}");
            Console.WriteLine($"Miles: {miles}");
        }
    }
}
