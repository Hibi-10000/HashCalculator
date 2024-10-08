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
using System.Buffers.Binary;
using System.Security.Cryptography;

namespace Hash.Core
{
    //public class CRC8       () : CRC(1, 0x7, 0xff);
    //public class CRC16_CCITT() : CRC(2, 0x8408, 0xffff);
    //public class CRC16_IBM  () : CRC(2, 0xA001, 0xffff);
    public class CRC32     () : CRC(4, 0xEDB88320, 0xffffffff);
    public class CRC32C    () : CRC(4, 0x82F63B78, 0xffffffff);
    public class CRC64_ECMA() : CRC(8, 0xC96C5795D7870F42, 0xffffffffffffffff);
    public class CRC64_ISO () : CRC(8, 0xD800000000000000, 0xffffffffffffffff);

    public class CRC : HashAlgorithm
    {
        private ulong _hash;
        private readonly ulong[] _table;
        private readonly ulong _seed;
        private readonly int _size;

        protected CRC(int size, ulong revPoly, ulong init)
        {
            _table = InitializeTable(revPoly);
            _seed = init;
            _size = size;
            HashSizeValue = size * 4;
            Initialize();
        }

        public override void Initialize()
        {
            _hash = _seed;
        }

        protected override void HashCore(byte[] buffer, int start, int length)
        {
            _hash = CalculateHash(_table, _hash, buffer, start, length);
        }

        protected override byte[] HashFinal()
        {
            byte[] hashBuffer = ULongToBigEndianBytes(~_hash);
            HashValue = hashBuffer;
            return hashBuffer;
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
            Span<byte> buffer = stackalloc byte[_size];
            switch (_size)
            {
                //case 1: //8
                //    buffer[0] = (byte)x;
                //    break;
                case 2: //16
                    BinaryPrimitives.WriteUInt16BigEndian(buffer, (ushort)x);
                    break;
                case 4: //32
                    BinaryPrimitives.WriteUInt32BigEndian(buffer, (uint)x);
                    break;
                case 8: //64
                    BinaryPrimitives.WriteUInt64BigEndian(buffer, x);
                    break;
            }
            return buffer.ToArray();
        }
    }
}
