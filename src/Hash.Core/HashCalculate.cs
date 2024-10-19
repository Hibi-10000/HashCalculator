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
                new("MD5"        , GetProvider(          MD5     .Create   ), true                      ),
                new("SHA1"       , GetProvider(          SHA1    .Create   ), true                      ),
                new("SHA256"     , GetProvider(          SHA256  .Create   ), true                      ),
                new("SHA384"     , GetProvider(          SHA384  .Create   ), true                      ),
                new("SHA512"     , GetProvider(          SHA512  .Create   ), true                      ),
                new("SHA3-256"   , GetProvider(          SHA3_256.Create   ), true, SHA3_256.IsSupported),
                new("SHA3-384"   , GetProvider(          SHA3_384.Create   ), true, SHA3_384.IsSupported),
                new("SHA3-512"   , GetProvider(          SHA3_512.Create   ), true, SHA3_512.IsSupported),
                new("CRC16-CCITT", GetProvider(() => new CRC16_CCITT()     ), true                      ),
                new("CRC16-IBM"  , GetProvider(() => new CRC16_IBM()       )                            ),
                new("CRC32"      , GetProvider(() => new CRC32()           ), true                      ),
                new("CRC32C"     , GetProvider(() => new CRC32C()          )                            ),
                new("CRC64-ECMA" , GetProvider(() => new CRC64_ECMA()      ), true                      ),
                new("CRC64-ISO"  , GetProvider(() => new CRC64_ISO()       )                            ),
                new("CRC64-XZ"   , GetProvider(() => new CRC64_XZ()        ), true                      ),
                new("RIPEMD160"  , GetProvider(() => new RIPEMD160Managed())                            ),
                new("xxHash32"   , GetProvider(() => new XxHash32()        )                            ),
                new("xxHash64"   , GetProvider(() => new XxHash64()        )                            ),
                new("xxHash3"    , GetProvider(() => new XxHash3()         ), true                      ),
                new("xxHash128"  , GetProvider(() => new XxHash128()       )                            ),
            ];

            internal readonly string Name;
            internal readonly IHashProvider Provider;
            internal readonly bool Visible;
            internal readonly bool Supported;

            private HashType(string name, IHashProvider provider, bool visible = false, bool supported = true)
            {
                Name = name;
                Provider = provider;
                Visible = visible;
                Supported = supported;
            }

            private static HashProvider GetProvider(Func<HashAlgorithm> providerFunc)
            {
                return new HashProvider(providerFunc);
            }

            private static NonCryptoHashProvider GetProvider(Func<NonCryptographicHashAlgorithm> providerFunc)
            {
                return new NonCryptoHashProvider(providerFunc);
            }
            
            internal interface IHashProvider
            {
                internal byte[] ComputeHash(Stream stream);
            }
            
            private class HashProvider(Func<HashAlgorithm> providerFunc) : IHashProvider
            {
                public byte[] ComputeHash(Stream stream)
                {
                    return providerFunc().ComputeHash(stream);
                }
            }

            private class NonCryptoHashProvider(Func<NonCryptographicHashAlgorithm> providerFunc) : IHashProvider
            {
                public byte[] ComputeHash(Stream stream)
                {
                    NonCryptographicHashAlgorithm provider = providerFunc();
                    provider.Append(stream);
                    return provider.GetCurrentHash();
                }
            }
        }

        public static string[] GetHashTypeNames(bool includeHidden = false)
        {
            return (
                from type in HashType.Types
                where type.Supported && (includeHidden || type.Visible)
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
            byte[] bs = hashType.Provider.ComputeHash(fs);

            string returnStr = BitConverter.ToString(bs);
            returnStr = upper ? returnStr.ToUpper() : returnStr.ToLower();
            return hyphen ? returnStr : returnStr.Replace("-", "");
        }
    }
}
