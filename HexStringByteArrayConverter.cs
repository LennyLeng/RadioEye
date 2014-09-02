using System;
using System.Text;
using System.Text.RegularExpressions;


namespace CSHexStringByteArrayConverter
{
    class HexStringByteArrayConverter
    {
        private const string hexDigits = "0123456789ABCDEF";

        public static string BytesToHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                sb.AppendFormat("{0:X2}", b);
            }
            return sb.ToString();
        }

        public static byte[] HexStringToBytes(string str)
        {
            // Determine the number of bytes 
            byte[] bytes = new byte[str.Length >> 1];
            for (int i = 0; i < str.Length; i += 2)
            {
                int highDigit = hexDigits.IndexOf(Char.ToUpperInvariant(str[i]));
                int lowDigit = hexDigits.IndexOf(Char.ToUpperInvariant(str[i + 1]));
                if (highDigit == -1 || lowDigit == -1)
                {
                    throw new ArgumentException("The string contains an invalid digit.", "s");
                }
                bytes[i >> 1] = (byte)((highDigit << 4) | lowDigit);
            }
            return bytes;
        }

        public static bool VerifyHexString(string str)
        {
            Regex regex = new Regex("\\A[0-9a-fA-F]+\\z");
            return regex.IsMatch(str) && ((str.Length & 1) != 1);
        }
    }
}