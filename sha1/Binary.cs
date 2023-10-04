using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace sha1
{
    internal class BinaryHandler
    {
        private List<byte> binaryValue;

        public BinaryHandler(string input)
        {
            byte[] binArr = Encoding.UTF8.GetBytes(input);
            binaryValue = new List<byte>(binArr);
        }

        public void RightShift(int shiftVal)
        {
            binaryValue = binaryValue.Select(b => (byte)(b >> shiftVal)).ToList();
        }

        public void LeftShift(int shiftVal)
        {
            binaryValue = binaryValue.Select(b => (byte)(b << shiftVal)).ToList();
        }

        public void And(BinaryHandler other)
        {
            binaryValue = binaryValue.Zip(other.binaryValue, (b1, b2) => (byte)(b1 & b2)).ToList();
        }

        public void Or(BinaryHandler other)
        {
            binaryValue = binaryValue.Zip(other.binaryValue, (b1, b2) => (byte)(b1 | b2)).ToList();
        }

        public void Xor(BinaryHandler other)
        {
            binaryValue = binaryValue.Zip(other.binaryValue, (b1, b2) => (byte)(b1 ^ b2)).ToList();
        }

        public override string ToString()
        {
            return new StringBuilder().AppendJoin("", binaryValue).ToString();
        }

        public string ToHex()
        {
            return new BigInteger(binaryValue.ToArray()).ToString("X");
        }
    }
}
