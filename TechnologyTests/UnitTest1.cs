using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        Computer testComputer = new Computer();
        Laptop testLaptopOne = new Laptop("MacOS", 0.512, true, 55);
        SmartPhone testSmartPhone = new SmartPhone("AndroidOS", 32, true);

        [TestMethod]
        public void TestComputerCheckPower()
        {
            Assert.IsFalse(testComputer.IsOn);
        }

        [TestMethod]
        public void TestComputerPowerOn()
        {
            testComputer.PowerOn();
            Assert.IsTrue(testComputer.IsOn);
        }

        [TestMethod]
        public void TestComputerOS()
        {
            Computer testComputerTwo = new Computer("Windows", 8);
            Assert.AreEqual("Windows", testComputerTwo.OpSystem);
        }

        [TestMethod]
        public void TestLaptopOS()
        {
            Assert.AreEqual("MacOS", testLaptopOne.OpSystem);
        }

        [TestMethod]
        public void TestLaptopBatteryLeft()
        {
            Assert.AreEqual(55, testLaptopOne.BatteryLeft);
        }

        [TestMethod]
        public void TestLaptopCheckBattery()
        {
            Assert.AreEqual("The battery is at 55%", testLaptopOne.CheckBattery());
        }

        
        [TestMethod]
        public void TestSmartPhoneMemory()
        {
            Assert.AreEqual(32, testSmartPhone.Memory, 0.001);
        }

        [TestMethod]
        public void TestSmartPhoneNumber()
        {
            Assert.AreEqual(1023456789, testSmartPhone.PhoneNumber);
        }

        [TestMethod]
        public void TestSmartPhoneMakeCall()
        {
            Assert.AreEqual("Making a call from phone number 1023456789...", testSmartPhone.MakeCall());
        }
        
    }
}
