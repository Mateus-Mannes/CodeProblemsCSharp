using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class Binary_To_String
    {
        public static string PrintBinary(double number)
        {
            if (number >= 1 || number <= 0)
            {
                return "ERROR";
            }

            var binary = new StringBuilder();
            binary.Append(".");

            while (number > 0)
            {
                /* Setting a limit on length: 32 characters */
                if (binary.Length > 32)
                {
                    return "ERROR";
                }

                var r = number * 2;

                if (r >= 1)
                {
                    binary.Append(1);
                    number = r - 1;
                }
                else
                {
                    binary.Append(0);
                    number = r;
                }
            }

            return binary.ToString();
        }

        public static string PrintBinary2(double number)
        {
            if (number >= 1 || number <= 0)
            {
                return "ERROR";
            }

            var binary = new StringBuilder();
            var frac = 0.5;
            binary.Append(".");

            while (number > 0)
            {
                /* Setting a limit on length: 32 characters */
                if (binary.Length >= 32)
                {
                    return "ERROR";
                }
                if (number >= frac)
                {
                    binary.Append(1);
                    number -= frac;
                }
                else
                {
                    binary.Append(0);
                }
                frac /= 2;
            }

            return binary.ToString();
        }
    }
}
