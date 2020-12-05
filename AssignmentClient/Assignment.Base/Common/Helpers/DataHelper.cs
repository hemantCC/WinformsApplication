using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Common.Helpers
{
    public class DataHelper
    {
        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        public static string EncryptString(string input)
        {
            byte[] key = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] iv = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            SymmetricAlgorithm algorithm = DES.Create();
            ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
            byte[] inputbuffer = Encoding.Unicode.GetBytes(input);
            byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
            return Convert.ToBase64String(outputBuffer).Replace("+","\\");
        }
    }
}
