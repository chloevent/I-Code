using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Degree
    {
        // C to F Multiply by 9, then divide by 5, then add 32
        public double CtoF(double value)
        {
            return (value * 9) / 5 + 32;
        }

        //F to C Deduct 32, then multiply by 5, then divide by 9
        public double FtoC(double value)
        {
            return (value - 32) * 5 / 9;
        }
    }
}
