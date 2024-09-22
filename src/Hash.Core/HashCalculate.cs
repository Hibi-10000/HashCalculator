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
        internal class HashType
        {
            internal static readonly HashType[] Types = [
                new("MD5"        ,           MD5     .Create                                             ),
                new("SHA1"       ,           SHA1    .Create                                             ),
                new("SHA256"     ,           SHA256  .Create                                             ),
                new("SHA384"     ,           SHA384  .Create                                             ),
                new("SHA512"     ,           SHA512  .Create                                             ),
                new("SHA3-256"   ,           SHA3_256.Create                , SHA3_256.IsSupported       ),
                new("SHA3-384"   ,           SHA3_384.Create                , SHA3_384.IsSupported       ),
                new("SHA3-512"   ,           SHA3_512.Create                , SHA3_512.IsSupported       ),
                new("CRC16-IBM"  , () => new CRC(CRC.Polynomial.CRC16_IBM  ), true                , true ),
                new("CRC16-CCITT", () => new CRC(CRC.Polynomial.CRC16_CCITT)                             ),
                new("CRC32"      , () => new CRC(CRC.Polynomial.CRC32      )                             ),
                new("CRC32C"     , () => new CRC(CRC.Polynomial.CRC32C     ), true                , true ),
                new("CRC64-ECMA" , () => new CRC(CRC.Polynomial.CRC64_ECMA )                             ),
                new("CRC64-ISO"  , () => new CRC(CRC.Polynomial.CRC64_ISO  ), true                , true ),
                new("RIPEMD160"  , () => new RIPEMD160Managed()             , true                , true ),
            ];

            internal readonly string Name;
            internal readonly Func<HashAlgorithm> ProviderFunc;
            internal readonly bool Supported;
            internal readonly bool Hidden;

            private HashType(string name, Func<HashAlgorithm> providerFunc, bool supported = true, bool hidden = false)
            {
                Name = name;
                ProviderFunc = providerFunc;
                Supported = supported;
                Hidden = hidden;
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
            byte[] bs = hashType.ProviderFunc().ComputeHash(fs);

            string returnStr = BitConverter.ToString(bs);
            returnStr = upper ? returnStr.ToUpper() : returnStr.ToLower();
            return hyphen ? returnStr : returnStr.Replace("-", "");
        }
    }
}
