namespace PayDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double MONTHLY_WORKING_DAYS = 22;
            const double DAILY_WORKING_HOURS = 8;
            const double HOURLY_WORKING_MINUTES = 60;

            double payByDay = 0;
            double payByHour = 0;
            double payByMinute = 0;

            double salary = 0;

            Console.WriteLine("Please type your salary: ");
            if(!double.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            {
                Console.WriteLine("Your salary must be a positive integer number! ");
                return;
            }

            payByDay = salary / MONTHLY_WORKING_DAYS;
            payByHour = payByDay / DAILY_WORKING_HOURS;
            payByMinute = payByHour / HOURLY_WORKING_MINUTES;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by day is: {payByDay:N2} \u20AC");
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by hour is: {payByHour:N2} \u20AC");
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by minute is: {payByMinute:N2} \u20AC");
        }
        
    }
}
