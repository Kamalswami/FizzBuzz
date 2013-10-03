using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public class Helper
    {
        public IEnumerable<string> FizzBuzz(ulong n1, ulong n2)
        {
            for (; n1 <= n2; n1++)
            {
                if (n1 % 15 == 0)
                {
                    yield return "FizzBuzz";
                }
                else if (n1 % 5 == 0)
                {
                    yield return "Buzz";
                }
                else if (n1 % 3 == 0)
                {
                    yield return "Fizz";
                }
                else
                {
                    yield return n1.ToString();
                }
            }
        }
    }
}
