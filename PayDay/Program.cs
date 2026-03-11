namespace PayDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MONTHLY_WORKING_DAYS = 22;
            const int DAILY_WORKING_HOURS = 8;
            const int HOURLY_WORKING_MINUTES = 60;

            int payByDay = 0;
            int payByHour = 0;
            int payByMinute = 0;

            int salary = 0;

            Console.WriteLine("Please type your salary: ");
            if(!int.TryParse(Console.ReadLine(), out salary) || salary <= 0)
            {
                Console.WriteLine("Your salary must be a positive integer number! ");
                return;
            }

            payByDay = salary / MONTHLY_WORKING_DAYS;
            payByHour = payByDay / DAILY_WORKING_HOURS;
            payByMinute = payByHour / HOURLY_WORKING_MINUTES;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by day is: {payByDay} \u20AC");
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by hour is: {payByHour} \u20AC");
            Console.WriteLine($"Your salary's: {salary} \u20AC pay by minute is: {payByMinute} \u20AC");
        }
        
    }
}
