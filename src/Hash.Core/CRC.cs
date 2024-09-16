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

using System.Security.Cryptography;

namespace Hash.Core
{
    public class CRC : HashAlgorithm
    {
        public enum Polynomial : ulong
        {
            //CRC8 = 0x7,
            CRC16_CCITT = 0x8408,
            CRC16_IBM = 0xA001,
            CRC32 = 0xEDB88320,
            CRC32C = 0x82F63B78,
            CRC64_ECMA = 0xC96C5795D7870F42,
            CRC64_ISO = 0xD800000000000000,
        }

        private ulong GetSeed()
        {
            return poly switch
            {
                //Polynomial.CRC8 => 0xff,
                Polynomial.CRC16_CCITT or
                Polynomial.CRC16_IBM => 0xffff,
                Polynomial.CRC32 or
                Polynomial.CRC32C => 0xffffffff,
                Polynomial.CRC64_ECMA or
                Polynomial.CRC64_ISO => 0xffffffffffffffff,
                _ => 0xffffffffffffffff,
            };
        }

        private readonly Polynomial poly;
        private ulong hash;
        private readonly ulong seed;
        private readonly ulong[] table;

        public CRC(Polynomial polynomial)
        {
            poly = polynomial;
            table = InitializeTable((ulong)polynomial);
            seed = GetSeed();
            Initialize();
        }

        public override void Initialize()
        {
            hash = seed;
        }

        protected override void HashCore(byte[] buffer, int start, int length)
        {
            hash = CalculateHash(table, hash, buffer, start, length);
        }

        protected override byte[] HashFinal()
        {
            byte[] hashBuffer = ULongToBigEndianBytes(~hash);
            HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize
        {
            get
            {
                return poly switch
                {
                    //Polynomial.CRC8 => 8,
                    Polynomial.CRC16_CCITT or
                    Polynomial.CRC16_IBM => 16,
                    Polynomial.CRC32 or
                    Polynomial.CRC32C => 32,
                    Polynomial.CRC64_ECMA or
                    Polynomial.CRC64_ISO => 64,
                    _ => 64,
                };
            }
        }

        private static ulong[] InitializeTable(ulong polynomial)
        {
            ulong[] createTable = new ulong[256];
            for (int i = 0; i < 256; i++)
            {
                ulong entry = (ulong)i;
                for (int j = 0; j < 8; j++)
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                createTable[i] = entry;
            }
            return createTable;
        }

        private static ulong CalculateHash(ulong[] table, ulong seed, byte[] buffer, int start, int size)
        {
            ulong crc = seed;
            for (int i = start; i < size; i++)
            {
                crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
            }
            return crc;
        }

        private byte[] ULongToBigEndianBytes(ulong x)
        {
            return poly switch
            {
                Polynomial.CRC16_CCITT or
                Polynomial.CRC16_IBM => [
                    (byte)((x >> 8) & 0xff),
                    (byte)(x & 0xff)
                ],
                Polynomial.CRC32 or
                Polynomial.CRC32C => [
                    (byte)((x >> 24) & 0xff),
                    (byte)((x >> 16) & 0xff),
                    (byte)((x >> 8) & 0xff),
                    (byte)(x & 0xff)
                ],
                Polynomial.CRC64_ECMA or
                Polynomial.CRC64_ISO => [
                    (byte)((x >> 56) & 0xff),
                    (byte)((x >> 48) & 0xff),
                    (byte)((x >> 40) & 0xff),
                    (byte)((x >> 32) & 0xff),
                    (byte)((x >> 24) & 0xff),
                    (byte)((x >> 16) & 0xff),
                    (byte)((x >> 8) & 0xff),
                    (byte)(x & 0xff)
                ],
                _ => [],
            };
        }
    }
}
