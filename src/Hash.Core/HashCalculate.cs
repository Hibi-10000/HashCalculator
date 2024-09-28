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
using System.IO.Hashing;
using System.Linq;
using System.Security.Cryptography;

namespace Hash.Core
{
    public static class HashCalculate
    {
        internal class HashType
        {
            internal static readonly HashType[] Types = [
                new("MD5"        , stream => func(stream,     MD5     .Create()              )                             ),
                new("SHA1"       , stream => func(stream,     SHA1    .Create()              )                             ),
                new("SHA256"     , stream => func(stream,     SHA256  .Create()              )                             ),
                new("SHA384"     , stream => func(stream,     SHA384  .Create()              )                             ),
                new("SHA512"     , stream => func(stream,     SHA512  .Create()              )                             ),
                new("SHA3-256"   , stream => func(stream,     SHA3_256.Create()              ), false, SHA3_256.IsSupported),
                new("SHA3-384"   , stream => func(stream,     SHA3_384.Create()              ), false, SHA3_384.IsSupported),
                new("SHA3-512"   , stream => func(stream,     SHA3_512.Create()              ), false, SHA3_512.IsSupported),
                new("CRC16-IBM"  , stream => func(stream, new CRC(CRC.Polynomial.CRC16_IBM  )), true                       ),
                new("CRC16-CCITT", stream => func(stream, new CRC(CRC.Polynomial.CRC16_CCITT))                             ),
                new("CRC32"      , stream => func(stream, new CRC(CRC.Polynomial.CRC32      ))                             ),
                new("CRC32C"     , stream => func(stream, new CRC(CRC.Polynomial.CRC32C     )), true                       ),
                new("CRC64-ECMA" , stream => func(stream, new CRC(CRC.Polynomial.CRC64_ECMA ))                             ),
                new("CRC64-ISO"  , stream => func(stream, new CRC(CRC.Polynomial.CRC64_ISO  )), true                       ),
                new("RIPEMD160"  , stream => func(stream, new RIPEMD160Managed()             ), true                       ),
                new("xxHash32"   , stream => func(stream, new XxHash32()                     ), true                       ),
                new("xxHash64"   , stream => func(stream, new XxHash64()                     ), true                       ),
                new("xxHash3"    , stream => func(stream, new XxHash3()                      )                             ),
                new("xxHash128"  , stream => func(stream, new XxHash128()                    ), true                       ),
            ];

            internal readonly string Name;
            internal readonly Func<FileStream, byte[]> ComputeFunc;
            internal readonly bool Hidden;
            internal readonly bool Supported;

            private HashType(string name, Func<FileStream, byte[]> computeFunc, bool hidden = false, bool supported = true)
            {
                Name = name;
                ComputeFunc = computeFunc;
                Hidden = hidden;
                Supported = supported;
            }

            private static byte[] func(Stream stream, HashAlgorithm provider)
            {
                return provider.ComputeHash(stream);
            }

            private static byte[] func(Stream stream, NonCryptographicHashAlgorithm provider)
            {
                provider.Append(stream);
                return provider.GetCurrentHash();
            }
        }

        public static string[] GetHashTypeNames(bool includeHidden = false)
        {
            return (
                from type in HashType.Types
                where type.Supported && (includeHidden || !type.Hidden)
                select type.Name
            ).ToArray();
        }

        public static string? GetHash(string hashType, string filePath, bool upper, bool hyphen)
        {
            foreach (HashType type in HashType.Types)
            {
                if (hashType == type.Name)
                {
                    return GetHash(type, filePath, upper, hyphen);
                }
            }
            return null;
        }

        private static string GetHash(HashType hashType, string filePath, bool upper, bool hyphen)
        {
            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //using MemoryStream fs = new MemoryStream(System.Text.Encoding.ASCII.GetBytes("123456789"));
            byte[] bs = hashType.ComputeFunc(fs);

            string returnStr = BitConverter.ToString(bs);
            returnStr = upper ? returnStr.ToUpper() : returnStr.ToLower();
            return hyphen ? returnStr : returnStr.Replace("-", "");
        }
    }
}
