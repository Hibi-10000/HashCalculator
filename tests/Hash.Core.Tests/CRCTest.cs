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
using System.IO;
using System.IO.Hashing;

namespace Hash.Core.Tests;

[TestClass]
public class CRCTest
{
    private static string CalcHash(NonCryptographicHashAlgorithm provider)
    {
        byte[] bs = provider.GetCurrentHash();
        return BitConverter.ToString(bs).ToLower().Replace("-", "");
    }

    public static IEnumerable<object[]> DataSet =>
    [
        [ () => new CRC8_CCITT() , "f4"               ],
        [ () => new CRC16_CCITT(), "2189"             ],
        [ () => new CRC16_IBM()  , "bb3d"             ],
        [ () => new CRC32()      , "cbf43926"         ],
        [ () => new CRC32C()     , "e3069283"         ],
        [ () => new CRC64_ECMA() , "6c40df5f0b497347" ],
        [ () => new CRC64_ISO()  , "b90956c775a41001" ],
        [ () => new CRC64_XZ()   , "995dc9bbdf1939fa" ],
    ];

    [TestMethod]
    [DynamicData(nameof(DataSet))]
    public void VerifyAppend(Func<NonCryptographicHashAlgorithm> providerFunc, string expectStr)
    {
        NonCryptographicHashAlgorithm provider = providerFunc();

        using MemoryStream ms2 = new MemoryStream("12345"u8.ToArray());
        provider.Append(ms2);
        using MemoryStream ms3 = new MemoryStream("6789"u8.ToArray());
        provider.Append(ms3);

        string returnStr = CalcHash(provider);
        Assert.AreEqual(expectStr, returnStr);
    }

    [TestMethod]
    [DynamicData(nameof(DataSet))]
    public void VerifyReset(Func<NonCryptographicHashAlgorithm> providerFunc, string expectStr)
    {
        NonCryptographicHashAlgorithm provider = providerFunc();

        using MemoryStream ms = new MemoryStream("777"u8.ToArray());
        provider.Append(ms);
        provider.Reset();
        using MemoryStream ms2 = new MemoryStream("123456789"u8.ToArray());
        provider.Append(ms2);

        string returnStr = CalcHash(provider);
        Assert.AreEqual(expectStr, returnStr);
    }

    [TestMethod]
    [DataRow(sizeof(byte), 0x07UL, 0x00UL, true, "20")]
    public void VerifyHash(int size, ulong poly, ulong init, bool refInOut, string expectStr)
    {
        NonCryptographicHashAlgorithm provider = new CRC(size, poly, init, refInOut);
        using MemoryStream ms = new MemoryStream("123456789"u8.ToArray());
        provider.Append(ms);
        string returnStr = CalcHash(provider);
        Assert.AreEqual(expectStr, returnStr);
    }
}
