using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
            
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool check)
        {
            var sum = num1 + num2;
            if (check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (check == true && sum == 1)
            {
                return $"{sum} dollars";
            }
            else if (check == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
