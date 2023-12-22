using HW1Week5.Models;

namespace HW1Week5
{
    class program
    {
       public static void Main(string[] args)

        {
            Space myspace = new(DateTime.Now.Date, new TimeSpan(8, 0, 0), 10, "Monday");

            Console.WriteLine("Please Enter your Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter booking Date (yyyy-MM-dd)");
            DateTime BookingDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter booking Date (yyyy-MM-dd)");
            TimeSpan BookingTime = TimeSpan.Parse(Console.ReadLine());

            if (myspace.IsSpaceAvaliable( BookingDate, BookingTime))
            {
                myspace.AvaliableSpace--;
                Console.WriteLine($"Hello, {Name}! space booked successfully");
            }
            else
            {
                Console.WriteLine("Space is not avaliable");
            }




        }
    }
}
