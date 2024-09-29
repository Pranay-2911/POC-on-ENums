using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_ENums.Models
{
    internal class SwicthMethod
    {
        public enum TrafficLight
        {
            Red,
            Yellow,
            Green
        }

        public  static void ControlTraffic(TrafficLight light)
        {
            switch(light)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop!!!");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Get Ready!!!");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Go!!!");
                    break;
            }
        }
    }
}
