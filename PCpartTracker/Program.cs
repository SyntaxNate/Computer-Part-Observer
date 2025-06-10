using System;

namespace PCpartTracker
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "GPU Price Tracker";
            Console.WriteLine($"Today's date: {DateTime.Now.ToString("MMMM dd, yyyy")}");
            Console.WriteLine("Welcome to the GPU Price Tracker!");
            Console.WriteLine("We'll help you keep an eye on PC hardware deals.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== GPU Price Tracker Menu =====");
                Console.WriteLine("1. View Tracked GPUs");
                Console.WriteLine("2. Add New GPU");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option (1-3):");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nCurrently tracked GPUs will appear here...");
                        break;
                    case "2":
                        Console.WriteLine("\nYou chose to add a new GPU.");
                        break;
                    case "3":
                        Console.WriteLine("\nExiting the app. Have a Pleasant Day");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to Menu...");
                    Console.ReadLine();
                }
            }
        }

    }
}
