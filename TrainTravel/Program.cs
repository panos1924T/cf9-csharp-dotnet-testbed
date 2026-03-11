namespace TrainTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TICKET_COST_PER_KM = 0.12;

            double kilometers = 0;
            double kmPerHour = 0;

            double totalTime = 0;
            double totalTimeInMinutes = 0;
            int totalHours = 0;
            int totalMinutes = 0;
            double totalCost = 0;
            double totalCostWithDiscount = 0;
            

            Console.WriteLine("Please type the distance (in kilometers) from the destination");
            if(!double.TryParse(Console.ReadLine(), out kilometers) || kilometers < 0)
            {
                Console.WriteLine("The kilometers for the distance must be a positive number!");
                return;
            }

            Console.WriteLine("Please type the average speed (kilometers by the hour): ");
            if (!double.TryParse(Console.ReadLine(), out kmPerHour) || kmPerHour < 0)
            {
                Console.WriteLine("The average speed can't be negative or zero! you shall be moving!");
                return;
            }

            totalTime = kilometers / kmPerHour;
            totalTimeInMinutes = totalTime * 60;

            totalHours = (int)totalTimeInMinutes / 60;
            totalMinutes = (int)totalTimeInMinutes % 60;

            totalCost = kilometers * TICKET_COST_PER_KM;
            totalCostWithDiscount = totalCost * 0.8;


        }
    }
}
