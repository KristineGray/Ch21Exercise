using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public readonly int PhoneNumber = 1023456789;

        public SmartPhone(string os, double memory, bool isOn) : base(os, memory, isOn)
        {
            this.OpSystem = os;
            this.Memory = memory;
            this.IsOn = isOn;
        }
        public string MakeCall()
        {
            return $"Making a call from phone number {this.PhoneNumber}...";
        }
    }
}
