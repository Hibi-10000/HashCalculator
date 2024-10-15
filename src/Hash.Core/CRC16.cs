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

namespace Hash.Core;

public class CRC16_CCITT() : CRC16(0x1021);

public class CRC16_IBM() : CRC16(0x8005);

public abstract class CRC16 : NonCryptographicHashAlgorithm
{
    private const ushort InitialState = 0x0000;
    private const bool RefInOut = true;
    private const ushort XOROut = 0x0000;
    private const int Size = sizeof(ushort);

    private readonly ushort[] _table;
    private ushort _crc = InitialState;

    protected CRC16(ushort poly) : base(Size)
    {
        _table = InitializeTable(poly);
    }

    public override void Append(ReadOnlySpan<byte> source)
    {
        _crc = CalculateHash(_table, _crc, source);
    }

    public override void Reset()
    {
        _crc = InitialState;
    }

    protected override void GetCurrentHashCore(Span<byte> destination)
    {
        BinaryPrimitives.WriteUInt16BigEndian(destination, (ushort)(_crc ^ XOROut));
    }

    private static ushort[] InitializeTable(ushort poly)
    {
        ushort refPoly = RefInOut ? ReverseBits(poly) : poly;
        ushort[] table = new ushort[256];
        for (int i = 0; i < table.Length; i++)
        {
            ushort entry = (ushort)i;
            for (int j = 0; j < 8; j++)
            {
                if ((entry & 1) != 0)
                    entry = (ushort)((entry >> 1) ^ refPoly);
                else
                    entry = (ushort)(entry >> 1);
            }
            table[i] = entry;
        }
        return table;
    }
    
    private static ushort ReverseBits(ushort source) {
        ushort reverse = 0;
        for (int i = 0; i < 16; i++) {
            reverse = (ushort)((reverse << 1) | ((source >> i) & 1));
        }
        return reverse;
    }

    private static ushort CalculateHash(ushort[] table, ushort seed, ReadOnlySpan<byte> buffer)
    {
        ushort crc = seed;
        foreach (byte bufferEntry in buffer)
        {
            crc = (ushort)((crc >> 8) ^ table[(byte)(bufferEntry ^ crc)]);
        }
        return crc;
    }
}
