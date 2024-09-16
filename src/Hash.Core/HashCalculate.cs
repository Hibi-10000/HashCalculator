// Copyright © 2021-2024 Hibi_10000
// 
// This file is part of HashCalculator program.
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Hash.Core
{
    public static class HashCalculate
    {
        private enum HashType
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512,
            [ShouldCheckSupport]
            SHA3_256,
            [ShouldCheckSupport]
            SHA3_384,
            [ShouldCheckSupport]
            SHA3_512,
            CRC16_IBM,
            [Hidden]
            CRC16_CCITT,
            CRC32,
            [Hidden]
            CRC32C,
            CRC64_ECMA,
            [Hidden]
            CRC64_ISO,
            [Hidden]
            RIPEMD160,
        }

        [AttributeUsage(AttributeTargets.Field)]
        private class HiddenAttribute : Attribute;

        private static bool IsHidden(HashType hashType)
        {
            return hashType switch
            {
                HashType.CRC16_CCITT
                    or HashType.CRC32C
                    or HashType.CRC64_ISO
                    or HashType.RIPEMD160
                    => true,
                _ => false
            };
        }

        [AttributeUsage(AttributeTargets.Field)]
        private class ShouldCheckSupportAttribute : Attribute;

        private static bool IsSupported(HashType hashType)
        {
            return hashType switch
            {
                HashType.SHA3_256 => SHA3_256.IsSupported,
                HashType.SHA3_384 => SHA3_384.IsSupported,
                HashType.SHA3_512 => SHA3_512.IsSupported,
                _ => true
            };
        }

        public static string[] GetHashTypeNames(bool includeHidden = false)
        {
            return (
                from type in Enum.GetValues<HashType>()
                where IsSupported(type) && (includeHidden || !IsHidden(type))
                select type.ToString().Replace("_", "-")
            ).ToArray();
        }

        public static string? GetHash(string hashType, string filePath, bool upper, bool hyphen)
        {
            foreach (HashType type in Enum.GetValues<HashType>())
            {
                if (hashType.Replace("-", "_") == type.ToString())
                {
                    return GetHash(type, filePath, upper, hyphen);
                }
            }
            return null;
        }

        private static string GetHash(HashType hashType, string filePath, bool upper, bool hyphen)
        {
            HashAlgorithm hashProvider = hashType switch
            {
                HashType.MD5         => MD5   .Create(),
                HashType.SHA1        => SHA1  .Create(),
                HashType.SHA256      => SHA256.Create(),
                HashType.SHA384      => SHA384.Create(),
                HashType.SHA512      => SHA512.Create(),
                HashType.SHA3_256    => SHA3_256.Create(),
                HashType.SHA3_384    => SHA3_384.Create(),
                HashType.SHA3_512    => SHA3_512.Create(),
                HashType.CRC16_IBM   => new CRC(CRC.Polynomial.CRC16_IBM  ),
                HashType.CRC16_CCITT => new CRC(CRC.Polynomial.CRC16_CCITT),
                HashType.CRC32       => new CRC(CRC.Polynomial.CRC32      ),
                HashType.CRC32C      => new CRC(CRC.Polynomial.CRC32C     ),
                HashType.CRC64_ECMA  => new CRC(CRC.Polynomial.CRC64_ECMA ),
                HashType.CRC64_ISO   => new CRC(CRC.Polynomial.CRC64_ISO  ),
                HashType.RIPEMD160   => new RIPEMD160Managed(),
                _ => throw new ArgumentOutOfRangeException(nameof(hashType), hashType, null),
            };

            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //using MemoryStream fs = new MemoryStream(System.Text.Encoding.ASCII.GetBytes("123456789"));
            byte[] bs = hashProvider.ComputeHash(fs);

            string returnStr = BitConverter.ToString(bs);
            returnStr = upper ? returnStr.ToUpper() : returnStr.ToLower();
            return hyphen ? returnStr : returnStr.Replace("-", "");
        }
    }
}
