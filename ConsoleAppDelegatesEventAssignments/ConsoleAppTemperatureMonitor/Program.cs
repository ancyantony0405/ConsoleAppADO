using ConsoleAppTemperatureMonitor.Model;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppTemperatureMonitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();

            // Subscribe to event
            monitor.TemperatureReached += ShowCriticalMessage;
            
            // Enter temperature
            while (true)
            {
                Console.Write("Enter temperature: ");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    monitor.setTemperature(temp);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            
        }
        public static void ShowCriticalMessage(string message)
        {
            Console.WriteLine($"Critical message: {message}");
        }
    }
}
