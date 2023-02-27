using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    public class Primer
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            } else
            {
               int counter = 0;
                 for (int j = 2; j <= candidate / 2; j++)
                    {
                        if (candidate % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }
                    
                    if (counter == 0)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }

          }
        }
    }
}