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

            List<string> gpuList = new List<string>();



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
                        if (gpuList.Count == 0)
                        {
                            Console.WriteLine("\nNo GPUs have been added yet.");
                        }
                        else
                        {
                            Console.WriteLine("\nCurrently tracked GPUs:");
                            foreach (var gpu in gpuList)
                            {
                                Console.WriteLine($"- {gpu}");
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nYou chose to add a new GPU.");
                        Console.Write("Enter the name of the GPU:");
                        string newGpu = Console.ReadLine();
                        gpuList.Add(newGpu);
                        Console.WriteLine($"GPU '{newGpu}' added to the list!");
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
