using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodExercise
{
    class Operation
    {
        public static int multBy100 (int num1)
        {
            int c = num1 * 100;
            return c;
        }

        public static int multBy100(decimal num1)
        {
            decimal c = num1 * 100;
            return Convert.ToInt32(c);
        }

        public static int multBy100(string num1)
        {
            int c = 0;
            try
            {
                c = Convert.ToInt32(num1) * 100;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            
            return c;
        }

        public int multBy15(int num1, int num2 = 15)
        {
            int c = num1 * num2;
            return c;
        }

        public static void addAndDisplay(int num1, int num2)
        {
            num1 = num1 + 15;
            Console.WriteLine(num2);
        }

        public void divideData(int num)
        {
            int c = num / 2;
            Console.WriteLine(c);
        }
    }
}
