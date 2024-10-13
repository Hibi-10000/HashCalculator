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
using System.IO.Hashing;

namespace Hash.Core
{
    //public class CRC8       () : CRC(sizeof(byte), 0x7, 0x00);
    //public class CRC16_CCITT() : CRC(sizeof(ushort), 0x8408, 0x0000);
    //public class CRC16_IBM  () : CRC(sizeof(ushort), 0xA001, 0x0000);
    public class CRC32     () : CRC(sizeof(uint), 0xEDB88320, 0xffffffff);
    public class CRC32C    () : CRC(sizeof(uint), 0x82F63B78, 0xffffffff);
    public class CRC64_ECMA() : CRC(sizeof(ulong), 0xC96C5795D7870F42, 0xffffffffffffffff);
    public class CRC64_ISO () : CRC(sizeof(ulong), 0xD800000000000000, 0xffffffffffffffff);

    public class CRC : NonCryptographicHashAlgorithm
    {
        private ulong _hash;
        private readonly ulong[] _table;
        private readonly ulong _seed;
        private readonly ulong _xorOut;
        private readonly int _size;

        protected CRC(int size, ulong revPoly, ulong init): base(size)
        {
            _table = InitializeTable(revPoly);
            _seed = init;
            _xorOut = init;
            _size = size;
            _hash = _seed;
        }

        public override void Append(ReadOnlySpan<byte> source)
        {
            _hash = CalculateHash(_table, _hash, _xorOut, source);
        }

        public override void Reset()
        {
            _hash = _seed;
        }

        private static ulong[] InitializeTable(ulong polynomial)
        {
            ulong[] createTable = new ulong[256];
            for (int i = 0; i < 256; i++)
            {
                ulong entry = (ulong)i;
                for (int j = 0; j < 8; j++)
                {
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                }
                createTable[i] = entry;
            }
            return createTable;
        }

        private static ulong CalculateHash(ulong[] table, ulong seed, ulong xorOut, ReadOnlySpan<byte> buffer)
        {
            ulong crc = seed;
            foreach (byte bufferValue in buffer)
            {
                crc = (crc >> 8) ^ table[bufferValue ^ crc & 0xff];
            }
            return crc ^ xorOut;
        }

        protected override void GetCurrentHashCore(Span<byte> destination)
        {
            switch (_size)
            {
                //case sizeof(byte): //8
                //    destination[0] = (byte)_hash;
                //    break;
                case sizeof(ushort): //16
                    BinaryPrimitives.WriteUInt16BigEndian(destination, (ushort)_hash);
                    break;
                case sizeof(uint): //32
                    BinaryPrimitives.WriteUInt32BigEndian(destination, (uint)_hash);
                    break;
                case sizeof(ulong): //64
                    BinaryPrimitives.WriteUInt64BigEndian(destination, _hash);
                    break;
            }
        }
    }
}
