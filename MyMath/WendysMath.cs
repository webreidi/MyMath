using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    public class WendysMath
    {
        public double AbsoluteValue(double input)
        {

            double result = input;
            if (result < 0)
            {
                result = -result;
            }
            return result;
        }

        public double Rounder(double input)
        {
            double result = input;
            if (result - Math.Floor(result) >= 0.5)
            {
                result = Math.Floor(result) + 1;
            }
            else
            {
                result = Math.Floor(result);
            }
            return result;
        }

        public double Maxer(double a, double b)
        {
            double result = a;
            if (a < b)
            {
                result = b;
            }
            return result;
        }

        public double Minner(double a, double b)
        {
            double result = a;
            if (a > b)
            {
                result = b;
            }
            return result;
        }

        public double Power(double input, int power)
        {
            double result = input;
            if (power == 0)
            {
                result = 1;
            }
            else if (power > 0)
            {
                for (int i = 1; i < power; i++)
                {
                    result = result * input;
                }
            }
            else
            {
                for (int i = 1; i < -power; i++)
                {
                    result = result * input;
                }
                result = 1 / result;
            }
            return result;

        }

        public int Floorer(double input)
        {
            int result = (int)input;
            return result;
        }
        
        public int Ceilinger(double input)
        {
            int result = (int)input + 1;
            return result;
        }

    }
}
