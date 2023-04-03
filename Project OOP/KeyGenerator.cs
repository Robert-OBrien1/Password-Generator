/*
 * Robert O'Brien
 * CMPS-5113-101
 * November 15, 2022
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace Project_OOP
{
    /*
     * Class Name: KeyGenerator
     * Attributes: char[] myCharArray
     * Methods: GetUniqueKey(int size, bool b_Symbols, bool b_Numbers, bool b_Upper, bool b_Lower)
     *          GetUniqueKeyOriginal_BIASED(int size)
     * Purpose: Generate a string dependent on size, and characters that may or may not be allowed
     *          in the string.
     * 
     * String generation is heavily modified from this source below ↓
     * Original author: https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
     *                  https://stackoverflow.com/users/141172/eric-j
     */
    public class KeyGenerator
    {
        public static string GetUniqueKey(int size, bool b_Symbols, bool b_Numbers, bool b_Upper, bool b_Lower)
        {
            // if all characters allowed
            if(b_Symbols && b_Numbers && b_Upper && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
            // No Symbol
            else if (!b_Symbols && b_Numbers && b_Upper && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                return Generate(size, charArry);
            }

            // No Numbers
            else if (!b_Numbers && b_Symbols && b_Upper && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // No Uppercase
            else if (!b_Upper && b_Symbols && b_Numbers && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // No Lowercase
            else if (!b_Lower && b_Symbols && b_Numbers && b_Upper )
            {
                char[] charArry =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
            // Only Symbol
            else if (!b_Numbers && !b_Upper && !b_Lower && b_Symbols)
            {
                char[] charArry =
                    "!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // Only Number
            else if (!b_Symbols && !b_Upper && !b_Lower && b_Numbers)
            {
                char[] charArry =
                    "1234567890".ToCharArray();
                return Generate(size, charArry);
            }

            // Only Upper
            else if (!b_Symbols && !b_Numbers && !b_Lower && b_Upper)
            {
                char[] charArry =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                return Generate(size, charArry);
            }

            // Only Lower
            else if (!b_Symbols && !b_Numbers && !b_Upper && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                return Generate(size, charArry);
            }

            // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
            // No Symbol No Number
            else if (!b_Symbols && !b_Numbers && b_Upper && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                return Generate(size, charArry);
            }

            // No Symbol No Upper
            else if (!b_Symbols && !b_Upper && b_Numbers && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
                return Generate(size, charArry);
            }

            // No Symbol No Lower
            else if (!b_Symbols && !b_Lower && b_Numbers && b_Upper)
            {
                char[] charArry =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
                return Generate(size, charArry);
            }

            // No Number No Upper
            else if (!b_Numbers && !b_Upper && b_Symbols && b_Lower)
            {
                char[] charArry =
                    "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // No Number No Lower
            else if (!b_Numbers && !b_Lower && b_Symbols && b_Upper)
            {
                char[] charArry =
                    "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // No Upper No Lower
            else if (!b_Upper && !b_Lower && b_Symbols && b_Numbers)
            {
                char[] charArry =
                    "1234567890!@#$%^&*()_+-={}[]<>~`".ToCharArray();
                return Generate(size, charArry);
            }

            // else if no boxes selected
            else
            {
                return "( ͡° ͜ʖ ͡°)";
            }
        }

        public static string GetUniqueKeyOriginal_BIASED(int size)
        {
            char[] chars =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-={}[]<>~`".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static string Generate(int size, char[] charArry)
        {
            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % charArry.Length;

                result.Append(charArry[idx]);
            }
            return result.ToString();
        }
    }
}