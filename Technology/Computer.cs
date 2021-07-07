using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer
    {
        public string OpSystem { get; set; }
        public bool IsOn { get; set; }
        public double Memory { get; set; }

        public Computer() { }

        public Computer(string os, double memory, bool isOn = false)
        {
            this.OpSystem = os;
            this.Memory = memory;
            this.IsOn = isOn;
        }

        
        public void CheckPower()
        {
            if (this.IsOn) Console.WriteLine("This device is on.");
            else Console.WriteLine("This device is off");
        }
        public void PowerOn()
        {
            this.IsOn = true;
            Console.WriteLine("The power has been turned on");
        }
        public void PowerOff()
        {
            this.IsOn = false;
            Console.WriteLine("The power has been turned off");
        }
    }
}
