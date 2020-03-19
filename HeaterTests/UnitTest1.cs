using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zambion.Test;


namespace HeaterTests
{
    [TestClass]
    public class UnitTest1
    {
        const bool switch_on = true;
        const bool switch_off = false;


        [TestMethod]
        [Owner("Emily")]
        [TestCategory("Heater")]
        [Priority(1)] 
        [DataTestMethod]
        [DataRow(23.00f,false)] 
        [DataRow(23.01f,false)]
        [DataRow(22.99f,true)]
        /*if switch is on and temperature greater or equal to 23, return true, else return false*/
        public void HighTempWithSwitchOn(float temp, bool expected)
        {
                 
            bool result = Heater.SetState(temp, switch_on);
            Assert.AreEqual(expected, result);

        }        

        [TestMethod]
        [Owner("Emily")]
        [TestCategory("Heater")]
        [Priority(1)]
        [DataTestMethod]
        [DataRow(4.99f, true)]
        [DataRow(5.00f, true)]
        [DataRow(5.01f, false)]
        /*if switch is off and temperature less than  or equal to  5, return true, else return false*/
        public void LowTempWithSwitchOff(float temp, bool expected)
        {
                  
            bool result = Heater.SetState(temp, switch_off);
            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        [Owner("Emily")]
        [TestCategory("Heater")]
        [Priority(1)]
        [DataTestMethod]
        [DataRow(23.00f, false)]
        [DataRow(23.01f, false)]
        [DataRow(22.99f, false)]
        /*if switch is off and temperatrue is high,according to common sense, return false*/
        public void HighTempWithSwitchOff(float temp, bool expected)
        {
            bool result = Heater.SetState(temp, switch_off);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [Owner("Emily")]
        [TestCategory("Heater")]
        [Priority(1)]
        [DataTestMethod]
        [DataRow(4.99f, true)]
        [DataRow(5.00f, true)]
        [DataRow(5.01f, true)]
        /*if switch is on and temperature is low, according to common sense, return true*/
        public void LowTempWithSwitchOn(float temp, bool expected)
        {
            bool result = Heater.SetState(temp, switch_on);
            Assert.AreEqual(expected, result);
        }
        

    }
   
}
