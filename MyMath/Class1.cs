using System;

namespace MyMath
{
    public class Class1
    {

    }

    public class Rooter
    {
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
                //was: result = result - (result * result - input) / (2*result);
            }
            return result;
        }
    }

    public class Squarer
    {
        public double Square(double input)
        {
            double result = input;
            result = result * result;
            return result;

        }
    }

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
            } else{
                result = Math.Floor(result);
            }
            return result;
        }

        public double Maxer(double a, double b)
        {
            double result = a;
            if (a<b) {
                result = b;
            }
            return result;
        }

        public double Minner(double a, double b)
        {
            double result = a;
            if (a>b)
            {
                result = b;
            }
            return result;
        }

        public double Power(double input, int power) {
            double result = input;
            if (power == 0)
            {
                result = 1;
            } else if (power > 0)
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

    }
}