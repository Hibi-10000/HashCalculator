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
using System.Security.Cryptography;
using System.Text;

namespace Hash.Core.Tests;

[TestClass]
public class HashTest
{
    private const string TestString = "123456789";
    private static byte[] TestStringBytes => Encoding.ASCII.GetBytes(TestString);

    [TestMethod]
    [DataRow("MD5"        , "25f9e794323b453885f5181f1b624d0b")]
    [DataRow("SHA1"       , "f7c3bc1d808e04732adf679965ccc34ca7ae3441")]
    [DataRow("SHA256"     , "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225"                                                                )]
    [DataRow("SHA384"     , "eb455d56d2c1a69de64e832011f3393d45f3fa31d6842f21af92d2fe469c499da5e3179847334a18479c8d1dedea1be3"                                )]
    [DataRow("SHA512"     , "d9e6762dd1c8eaf6d61b3c6192fc408d4d6d5f1176d0c29169bc24e71c3f274ad27fcd5811b313d681f7e55ec02d73d499c95455b6b5bb503acf574fba8ffe85")]
    [DataRow("SHA3-256"   , "87cd084d190e436f147322b90e7384f6a8e0676c99d21ef519ea718e51d45f9c"                                                                )]
    [DataRow("SHA3-384"   , "8b90ede4d095409f1a12492c2520599683a9478dc70b7566d23b3e41ece8538c6cde92382a5e38786490375c54672abf"                                )]
    [DataRow("SHA3-512"   , "e1e44d20556e97a180b6dd3ed7ae5c465cafd553fa8747dca038fb95635b77a37318f7ddf7aec1f6c3c14bb160ba2497007decf38dd361cab199e3b8c8fe1f5c")]
    [DataRow("CRC8"       , "f4"              )]
    [DataRow("CRC16-CCITT", "2189"            )]
    [DataRow("CRC16-IBM"  , "bb3d"            )]
    [DataRow("CRC32"      , "cbf43926"        )]
    [DataRow("CRC32C"     , "e3069283"        )]
    [DataRow("CRC64-ECMA" , "6c40df5f0b497347")]
    [DataRow("CRC64-ISO"  , "b90956c775a41001")]
    [DataRow("CRC64-XZ"   , "995dc9bbdf1939fa")]
    [DataRow("RIPEMD160"  , "d3d0379126c1e5e0ba70ad6e5e53ff6aeab9f4fa")]
    [DataRow("xxHash32"   , "937bad67"                        )]
    [DataRow("xxHash64"   , "8cb841db40e6ae83"                )]
    [DataRow("xxHash3"    , "72dcb18b67a17dff"                )]
    [DataRow("xxHash128"  , "33119477ede5dcd5e9716427681d5860")]
    public void VerifyHash(string name, string expectStr)
    {
        var hashType = HashCalculate.HashType.Types[name];
        using MemoryStream ms = new MemoryStream(TestStringBytes);
        if (!hashType.Supported)
        {
            try {
                hashType.Provider.ComputeHash(ms);
            } catch (PlatformNotSupportedException) {
                Assert.Inconclusive();
                return;
            }
            Assert.Fail();
            return;
        }
        byte[] bs = hashType.Provider.ComputeHash(ms);
        string returnStr = BitConverter.ToString(bs).ToLower().Replace("-", "");
        Assert.AreEqual(expectStr, returnStr);
    }
    
    [TestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void VerifyHashTypeNames(bool includeHidden)
    {
        List<string> expect = [
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "CRC16-CCITT",
            "CRC32",
            "CRC64-ECMA",
            "CRC64-XZ",
            "xxHash3",
        ];
        if (SHA3_256.IsSupported)
        {
            expect.AddRange([
                "SHA3-256",
                "SHA3-384",
                "SHA3-512",
            ]);
        }
        if (includeHidden)
        {
            expect.AddRange([
                "CRC8",
                "CRC16-IBM",
                "CRC32C",
                "CRC64-ISO",
                "RIPEMD160",
                "xxHash32",
                "xxHash64",
                "xxHash128",
            ]);
        }
        string[] actual = HashCalculate.GetHashTypeNames(includeHidden);
        CollectionAssert.AreEquivalent(expect.ToArray(), actual);
    }
    
    private const string TestFilePath = "testFile.txt";

    [TestMethod]
    [DataRow("MD5"      , TestFilePath, "54302b01b82db587f8f9fa59a943d342")]
    [DataRow("SHA512"   , TestFilePath, "eb4b008a214f070debe0d764c79fc06c7d2347d6fadb7c074da1331bae22558f687aaea43431e4b443a72273424c6e3f548aa7c431b9dc48c01a91dab9e7d5c0")]
    [DataRow("CRC32C"   , TestFilePath, "8ca2a28d")]
    [DataRow("RIPEMD160", TestFilePath, "cb50bbda2b6c08c8d47320996cde6693b25cb34d")]
    [DataRow("xxHash64" , TestFilePath, "d8027ca16d208be3")]
    [DataRow("xxHash128", "", null)]
    public void VerifyGetHash_File(string hashType, string filePath, string? actual)
    {
        string? expect = HashCalculate.GetHash(hashType, filePath, false, false);
        Assert.AreEqual(expect, actual);
    }

    [TestMethod]
    [DataRow("MD5"      , false, true , "25-f9-e7-94-32-3b-45-38-85-f5-18-1f-1b-62-4d-0b")]
    [DataRow("SHA512"   , true , false, "D9E6762DD1C8EAF6D61B3C6192FC408D4D6D5F1176D0C29169BC24E71C3F274AD27FCD5811B313D681F7E55EC02D73D499C95455B6B5BB503ACF574FBA8FFE85")]
    [DataRow("CRC32"    , true , true , "CB-F4-39-26")]
    [DataRow("RIPEMD160", true , false, "D3D0379126C1E5E0BA70AD6E5E53FF6AEAB9F4FA")]
    [DataRow("xxHash3"  , true , false, "72DCB18B67A17DFF")]
    public void VerifyGetHash(string hashType, bool upper, bool hyphen, string actual)
    {
        using MemoryStream ms = new MemoryStream(TestStringBytes);
        string expect = HashCalculate.GetHash(hashType, ms, upper, hyphen);
        Assert.AreEqual(expect, actual);
    }
}
