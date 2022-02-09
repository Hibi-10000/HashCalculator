using System;
using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    internal class HashCalculate
    {
        public static string GetHashSHA256(string filePath)
        {
            HashAlgorithm hashProvider = new SHA256CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }

        public static string GetHashSHA1(string filePath)
        {
            HashAlgorithm hashProvider = new SHA1CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashMD5(string filePath)
        {
            HashAlgorithm hashProvider = new MD5CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA384(string filePath)
        {
            HashAlgorithm hashProvider = new SHA384CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
        public static string GetHashSHA512(string filePath)
        {
            HashAlgorithm hashProvider = new SHA512CryptoServiceProvider();
            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);
            return BitConverter.ToString(bs).ToLower().Replace("-", "");
        }
    }
}
