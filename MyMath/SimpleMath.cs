using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    public class SimpleMath
    {
        public double Adder(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Subtractor(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiplier(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Divider(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();

            }
            else
            {
                double result = a / b;
                return result;
            }
        }

        /// <summary>
        /// Doubles the given integer.
        /// </summary>
        /// <param name="x">The integer to be doubled.</param>
        /// <returns>The result of doubling the input integer.</returns>
        public int DoubleNum(int x)
        {
            return x * 2;
        }

    }
}
