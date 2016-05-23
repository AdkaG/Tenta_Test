using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_Test.Models.Tests
{
    [TestClass()]
    public class EnergyTests
    {
        [TestMethod()]
        public void CalculateEnergyTest()
        {
            //arange
            Energy energy = new Energy();
            //act
            var actual = energy.CalculateEnergy(5);
            var expected = 449377589368408820d;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void CalculateEnergyTest_NegativeMass()
        {
            //arange
            Energy energy = new Energy();
            //act
            var actual = energy.CalculateEnergy(-5);
            
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateEnergyTest_ZeroMass()
        {
            //arange
            Energy energy = new Energy();
            //act
            var actual = energy.CalculateEnergy(0);

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateEnergyTest_DoubleMaxValue()
        {
            //arange
            Energy energy = new Energy();
            //act
            var actual = energy.CalculateEnergy(Double.MaxValue);

        }
    }
}
//m = double max value/89875517873681764
//m = 