using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Degree
    {
        //Fields
        private double Fvalue;
        private double Cvalue;

        //Constructor
        public Degree()
        {
            Fvalue = 0.0;
            Cvalue = 0.0;
        }

        public void setFvalue(double fvalue)
        {
            Fvalue = fvalue;
        }

        public void setCvalue(double cvalue)
        {
            Cvalue = cvalue;
        }

        public double getFvalue()
        {
            return Fvalue;
        }

        public double getCvalue()
        {
            return Cvalue;
        }

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
