using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binaryHandling;
//check it out
using System.Security.Cryptography;

namespace sha1
{
    public static class Encode
    {
        private static string input;
        private static int inputLength;
        private static Binary inputBinary;
        private static long inputBinaryLength;
        private static Binary paddedInputBinary;
        private static long paddedInputBinaryLength;
        private static Binary output;

        private static void getInputAsBinary(string input)
        {
            Encode.input = input;
            Encode.inputLength = input.Length;
            Encode.inputBinary = new Binary(input);
            Encode.inputBinaryLength = inputBinary.GetLength();
        }

        public static void AddPadding(string input)
        {

            Encode.paddedInputBinaryLength = inputBinary.GetLength();

            if (inputBinaryLength % 512 == 448)
            {
                paddedInputBinary = new Binary(inputBinary.BinaryValue.Append((byte)1));
            }

            else
            {
                paddedInputBinary = new Binary(inputBinary.BinaryValue.Append((byte)1));
            }
            while (inputBinary.GetLength() % 512 != 0)
            {
                paddedInputBinary = new Binary(inputBinary.BinaryValue.Append((byte)0));
            }
            return;
        }   
    }
}
