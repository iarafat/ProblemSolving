using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Testing
    {
        static void Main(string[] args)
        {
            int value = 5069456;
            for (int i = 1; i < 38; i++)
            {
                try
                {
                    Console.WriteLine("base {0:00}: {1}", i, value.ToBase(i));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("unexpected exception: " + ex.Message);
                }
            }
            Console.WriteLine("base 64: {0}", Convert.ToBase64String(BitConverter.GetBytes(value)));
        }
        /// <summary>
        /// encodes an int value to the requested radix
        /// </summary>
        /// <remarks>
        /// base 2 to 36 and base64 are supported
        /// base64 follows RFC4648 rules
        /// </remarks>
        /// <param name="value">int value to encode</param>
        /// <param name="radix">radix for the encoding</param>
        /// <returns>base[radix] encoded string</returns>
        public static string ToBase(this int value, int radix)
        {
            if (radix != 64 && (radix < 2 || radix > 36))
            {
                throw new ArgumentOutOfRangeException(
                    "invalid radix [" + radix + "]." + Environment.NewLine +
                    "radix must be either 64 or between 2 and 36.");
            }
            // handle RFC4648 base64
            if (radix == 64) return value.ToBase64();
            // this algorithm doesn't like 0, just return tostring
            if (value == 0) return value.ToString();
            const string baseChars =
                "0123456789" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = new StringBuilder();
            int temp = value;
            // strips and encodes each digit based on the radix
            while (temp != 0)
            {
                result.Append(baseChars[temp % radix]);
                temp /= radix;
            }
            // the encoded string is backward after the loop
            return result.ToString().Reverse();
        }
        /// <summary>
        /// encodes an int value using RFC4648 base64 encoding
        /// </summary>
        /// <param name="value">int value to encode</param>
        /// <returns>base64 encoded string</returns>
        public static string ToBase64(this int value)
        {
            const string baseChars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            const char padding = '=';
            byte[] bytes = BitConverter.GetBytes(value);
            var retval = new StringBuilder();
            for (int i = 0; i < bytes.Length; i += 3)
            {
                byte[] workingSet = new byte[3];  // 8-bit bytes to be encoded
                byte[] sixBitGroup = new byte[4]; // 6-bit regrouping into 4 bytes
                // gets the next 3 bytes from the bytestream with
                workingSet[0] = bytes[i];
                workingSet[1] = (i + 1 < bytes.Length) ? bytes[i + 1] : (byte)0;
                workingSet[2] = (i + 2 < bytes.Length) ? bytes[i + 2] : (byte)0;
                // regroup the 8-bit bytes into 6-bit bytes
                sixBitGroup[0] = (byte)(workingSet[0] >> 2);
                sixBitGroup[1] = (byte)(((workingSet[0] & 0x3) << 4) | (workingSet[1] >> 4));
                sixBitGroup[2] = (byte)(((workingSet[1] & 0xf) << 2) | (workingSet[2] >> 6));
                sixBitGroup[3] = (byte)(workingSet[2] & 0x3f);
                // encode the 6-bit bytes using base64 chars
                retval.Append(baseChars[sixBitGroup[0]]);
                retval.Append(baseChars[sixBitGroup[1]]);
                retval.Append((i + 1 < bytes.Length) ? baseChars[sixBitGroup[2]] : padding);
                retval.Append((i + 1 < bytes.Length) ? baseChars[sixBitGroup[3]] : padding);
            };
            return retval.ToString();
        }
        /// <summary>
        /// reverses the characters in a string
        /// </summary>
        /// <param name="s">original string</param>
        /// <returns>reversed string</returns>
        public static string Reverse(this string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
