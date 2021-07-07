using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public int BatteryLeft { get; set; }

        public Laptop(string os, double memory, bool isOn, int batteryLeft = 100) : base(os, memory, isOn)
        {
            this.BatteryLeft = batteryLeft;
        }

        public string CheckBattery()
        {
            Console.WriteLine($"The battery is at {this.BatteryLeft}%");
            return $"The battery is at {this.BatteryLeft}%";
        }
    }
}
