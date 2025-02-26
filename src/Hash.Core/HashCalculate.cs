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
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Security.Cryptography;

namespace Hash.Core;

public static class HashCalculate
{
    internal class HashType
    {
        internal static readonly ImmutableDictionary<string, HashType> Types = new Dictionary<string, HashType>
        {
            ["MD5"        ] = new(GetProvider(          MD5     .Create   ), true                      ),
            ["SHA1"       ] = new(GetProvider(          SHA1    .Create   ), true                      ),
            ["SHA256"     ] = new(GetProvider(          SHA256  .Create   ), true                      ),
            ["SHA384"     ] = new(GetProvider(          SHA384  .Create   ), true                      ),
            ["SHA512"     ] = new(GetProvider(          SHA512  .Create   ), true                      ),
            ["SHA3-256"   ] = new(GetProvider(          SHA3_256.Create   ), true, SHA3_256.IsSupported),
            ["SHA3-384"   ] = new(GetProvider(          SHA3_384.Create   ), true, SHA3_384.IsSupported),
            ["SHA3-512"   ] = new(GetProvider(          SHA3_512.Create   ), true, SHA3_512.IsSupported),
            ["CRC8"       ] = new(GetProvider(() => new CRC8_CCITT()      )                            ),
            ["CRC16-CCITT"] = new(GetProvider(() => new CRC16_CCITT()     ), true                      ),
            ["CRC16-IBM"  ] = new(GetProvider(() => new CRC16_IBM()       )                            ),
            ["CRC32"      ] = new(GetProvider(() => new CRC32()           ), true                      ),
            ["CRC32C"     ] = new(GetProvider(() => new CRC32C()          )                            ),
            ["CRC64-ECMA" ] = new(GetProvider(() => new CRC64_ECMA()      ), true                      ),
            ["CRC64-ISO"  ] = new(GetProvider(() => new CRC64_ISO()       )                            ),
            ["CRC64-XZ"   ] = new(GetProvider(() => new CRC64_XZ()        ), true                      ),
            ["RIPEMD160"  ] = new(GetProvider(() => new RIPEMD160Managed())                            ),
            ["xxHash32"   ] = new(GetProvider(() => new XxHash32()        )                            ),
            ["xxHash64"   ] = new(GetProvider(() => new XxHash64()        )                            ),
            ["xxHash3"    ] = new(GetProvider(() => new XxHash3()         ), true                      ),
            ["xxHash128"  ] = new(GetProvider(() => new XxHash128()       )                            ),
        }.ToImmutableDictionary();

        internal readonly IHashProvider Provider;
        internal readonly bool Visible;
        internal readonly bool Supported;

        private HashType(IHashProvider provider, bool visible = false, bool supported = true)
        {
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
            where type.Value.Supported && (includeHidden || type.Value.Visible)
            select type.Key
        ).ToArray();
    }

    public static string? GetHash(string hashType, string filePath, bool upper, bool hyphen)
    {
        if (!File.Exists(filePath)) return null;
        using FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        return GetHash(hashType, fs, upper, hyphen);
    }

    internal static string GetHash(string hashType, Stream stream, bool upper, bool hyphen)
    {
        byte[] bs = HashType.Types[hashType].Provider.ComputeHash(stream);
        string returnStr = BitConverter.ToString(bs);
        returnStr = upper ? returnStr.ToUpper() : returnStr.ToLower();
        return hyphen ? returnStr : returnStr.Replace("-", "");
    }
}
