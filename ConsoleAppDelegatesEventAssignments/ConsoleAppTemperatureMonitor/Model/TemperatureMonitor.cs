using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTemperatureMonitor.Model
{
    // Declare delegate
    public delegate void CriticalTemperature(string message);

    public class TemperatureMonitor
    {
        public int temperature { get; set; }

        //  Declare event
        public event CriticalTemperature TemperatureReached;
        
        public void setTemperature(int temp)
        {
            temperature = temp;
            Console.WriteLine($"Temperature : {temperature}");

            if (temperature >100 || temperature < 0)
            {
                TemperatureReached.Invoke("Critical temperature reached");
            }
        }
       
    }
}
