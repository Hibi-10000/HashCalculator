// Copyright © 2021-present Hibi_10000
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

namespace Hash.Core;

public class CRC8_CCITT () : CRC(sizeof(byte), 0x07, 0x00, false);
public class CRC16_CCITT() : CRC(sizeof(ushort), 0x1021, 0x0000, true);
public class CRC16_IBM  () : CRC(sizeof(ushort), 0x8005, 0x0000, true);
public class CRC32      () : CRC(sizeof(uint), 0x04C11DB7, 0xffffffff, true);
public class CRC32C     () : CRC(sizeof(uint), 0x1EDC6F41, 0xffffffff, true);
public class CRC64_ECMA () : CRC(sizeof(ulong), 0x42F0E1EBA9EA3693, 0x0000000000000000, false);
public class CRC64_ISO  () : CRC(sizeof(ulong), 0x000000000000001B, 0xffffffffffffffff, true);
public class CRC64_XZ   () : CRC(sizeof(ulong), 0x42F0E1EBA9EA3693, 0xffffffffffffffff, true);

public class CRC : NonCryptographicHashAlgorithm
{
    private ulong _hash;
    private readonly ulong[] _table;
    private readonly ulong _seed;
    private readonly bool _refOut;
    private readonly ulong _xorOut;
    private readonly int _size;

    protected internal CRC(int size, ulong poly, ulong init, bool refInOut) : base(size)
    {
        _table = InitializeTable(size, poly, refInOut);
        _seed = init;
        _refOut = refInOut;
        _xorOut = init;
        _size = size;
        _hash = _seed;
    }

    public override void Append(ReadOnlySpan<byte> source)
    {
        _hash = CalculateHash(_size, _table, _hash, _refOut, source);
    }

    public override void Reset()
    {
        _hash = _seed;
    }

    private static ulong[] InitializeTable(int size, ulong poly, bool refIn)
    {
        ulong[] table = new ulong[256]; //byte.MaxValue + 1
        if (refIn)
        {
            for (int i = 0; i < 256; i++)
            {
                ulong entry = (ulong)i;
                for (int j = 0; j < 8; j++)
                {
                    if ((entry & 1) != 0)
                        entry = (entry >> 1) ^ ReverseBits(poly, size * 8);
                    else
                        entry >>= 1;
                }
                table[i] = size == sizeof(byte) ? (byte)entry : entry;
            }
        }
        else
        {
            for (int i = 0; i < 256; i++)
            {
                ulong entry = size == sizeof(byte) ? (ulong)i : (ulong)i << 56;
                for (int j = 0; j < 8; j++)
                {
                    if ((entry & ReverseBits(1, size * 8)) != 0)
                        entry = (entry << 1) ^ poly;
                    else
                        entry <<= 1;
                }
                table[i] = size == sizeof(byte) ? (byte)entry : entry;
            }
        }
        return table;
    }

    private static ulong ReverseBits(ulong source, int size)
    {
        ulong reverse = 0;
        for (int i = 0; i < size; i++)
        {
            reverse = (reverse << 1) | ((source >> i) & 1);
        }
        return reverse;
    }

    private static ulong CalculateHash(int size, ulong[] table, ulong seed, bool refOut, ReadOnlySpan<byte> buffer)
    {
        ulong crc = seed;
        if (refOut)
        {
            foreach (byte bufferEntry in buffer)
            {
                crc = (crc >> 8) ^ table[(byte)(bufferEntry ^ crc)];
            }
        }
        else
        {
            foreach (byte bufferEntry in buffer)
            {
                crc = (crc << 8) ^ table[(byte)(bufferEntry ^ (size == sizeof(byte) ? crc : crc >> 56))];
            }
        }
        return crc;
    }

    protected override void GetCurrentHashCore(Span<byte> destination)
    {
        ulong hash = _hash ^ _xorOut;
        switch (_size)
        {
            case sizeof(byte  ): //1  8
                destination[0] = (byte)hash;
                break;
            case sizeof(ushort): //2 16
                BinaryPrimitives.WriteUInt16BigEndian(destination, (ushort)hash);
                break;
            case sizeof(uint  ): //4 32
                BinaryPrimitives.WriteUInt32BigEndian(destination, (uint)  hash);
                break;
            case sizeof(ulong ): //8 64
                BinaryPrimitives.WriteUInt64BigEndian(destination,         hash);
                break;
        }
    }
}
