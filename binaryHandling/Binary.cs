using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace binaryHandling
{
    public class Binary
    {
        public List<byte> BinaryValue { get; set; }

        public Binary(string input)
        {
            byte[] binArr = Encoding.UTF8.GetBytes(input);
            BinaryValue = new List<byte>(binArr);
        }

        public Binary(IEnumerable<byte> input)
        {
            BinaryValue = new List<byte>(input);
        }

        public void RightShift(int shiftVal)
        {
            BinaryValue = BinaryValue.Select(b => (byte)(b >> shiftVal)).ToList();
        }

        public void LeftShift(int shiftVal)
        {
            BinaryValue = BinaryValue.Select(b => (byte)(b << shiftVal)).ToList();
        }

        public override string ToString()
        {
            return new StringBuilder().AppendJoin("", BinaryValue).ToString();
        }

        public long GetLength()
        {
            return BinaryValue.Count * 8;
        }

        public string ToHex()
        {
            return new BigInteger(BinaryValue.ToArray()).ToString("X");
        }
    }
}
