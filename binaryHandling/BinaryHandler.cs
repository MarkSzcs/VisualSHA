using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace binaryHandling
{
    public static class BinaryHandler
    {
        public static Binary And(Binary num1, Binary num2)
        {
            Binary result = new(num1.BinaryValue.Zip(num2.BinaryValue, (b1, b2) => (byte)(b1 & b2)).ToList());
            return result;
        }

        public static Binary Or(Binary num1, Binary num2)
        {
            Binary result = new(num1.BinaryValue.Zip(num2.BinaryValue, (b1, b2) => (byte)(b1 | b2)).ToList());
            return result;
        }

        public static Binary Xor(Binary num1, Binary num2)
        {
            Binary result = new(num1.BinaryValue.Zip(num2.BinaryValue, (b1, b2) => (byte)(b1 ^ b2)).ToList());
            return result;
        }
    }
}
