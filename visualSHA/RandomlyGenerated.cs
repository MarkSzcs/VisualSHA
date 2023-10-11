using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualSHA1
{
    public static class RandomlyGenerated
    {
        private static readonly Random RNG = new();

        public static char GenerateChar()
        {
            // 'Z' + 1 because the range is exclusive
            return (char)(RNG.Next('A', 'Z' + 1));
        }

        public static string GenerateBinary(int length)
        {
            byte[] bytes = new byte[length];
            RNG.NextBytes(bytes);
            return Convert.ToString(bytes).PadLeft(8, '0');

        }

        public static string GenerateString(int length)
        {
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
            {
                letters[i] = GenerateChar();
            }
            return new string(letters);
        }
    }
}
