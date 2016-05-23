using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenta_Test.Models
{
    public class Energy
    {
        public double CalculateEnergy(double mass)
        {
            const double speed = 299792458d;
            if (mass < 0 || mass > Double.MaxValue/ Math.Pow(speed, 2))
            {
                 throw new ArgumentOutOfRangeException();
            }
            var energy = mass * Math.Pow(speed, 2);
            return energy;
        }
    }
}