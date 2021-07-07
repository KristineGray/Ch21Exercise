using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public static int PhoneNumber { get; set; }

        public SmartPhone(int phoneNumber, string os, double memory, bool isOn) : base(os, memory, isOn)
        {
            PhoneNumber = phoneNumber;
            this.OpSystem = os;
            this.Memory = memory;
            this.IsOn = isOn;
        }

        public int GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public static string MakeCall()
        {
            Console.WriteLine($"Making a call from phone number {PhoneNumber}...");
            return $"Making a call from phone number {PhoneNumber}...";
        }
    }
}
