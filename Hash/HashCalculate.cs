using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Hash
{
    internal class HashCalculate
    {
        public enum HashType
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512,
            CRC16_IBM,
            CRC16_CCITT,
            CRC32,
            CRC64_ECMA_182,
            CRC64_ISO,
            MACTripleDES,
            RIPEMD160,
        }
        
        public static string GetHash(HashType hashtype, string filePath, bool upper, bool hihun)
        {
            HashAlgorithm hashProvider = null;
            switch (hashtype)
            {
                case HashType.MD5:
                    hashProvider = new MD5CryptoServiceProvider();
                    break;
                case HashType.SHA1:
                    hashProvider = new SHA1CryptoServiceProvider();
                    break;
                case HashType.SHA256:
                    hashProvider = new SHA256CryptoServiceProvider();
                    break;
                case HashType.SHA384:
                    hashProvider = new SHA384CryptoServiceProvider();
                    break;
                case HashType.SHA512:
                    hashProvider = new SHA512CryptoServiceProvider();
                    break;
                case HashType.CRC16_IBM:
                    hashProvider = new CRC(CRC.Polynomial.CRC16_IBM);
                    break;
                case HashType.CRC16_CCITT:
                    hashProvider = new CRC(CRC.Polynomial.CRC16_CCITT);
                    break;
                case HashType.CRC32:
                    hashProvider = new CRC(CRC.Polynomial.CRC32);
                    break;
                case HashType.CRC64_ECMA_182:
                    hashProvider = new CRC(CRC.Polynomial.CRC64_ECMA182);
                    break;
                case HashType.CRC64_ISO:
                    hashProvider = new CRC(CRC.Polynomial.CRC64_ISO);
                    break;
                case HashType.MACTripleDES:
                    hashProvider = new MACTripleDES();
                    break;
                case HashType.RIPEMD160:
                    hashProvider = new RIPEMD160Managed();
                    break;
            }

            var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var bs = hashProvider.ComputeHash(fs);

            string return_str = BitConverter.ToString(bs);
            if (upper)
            {
                return_str = return_str.ToUpper();
            }
            else
            {
                return_str = return_str.ToLower();
            }
            if (!hihun)
            {
                return_str = return_str.Replace("-", "");
            }
            return return_str;
        }
    }

    public class CRC : HashAlgorithm
    {
        public enum Polynomial : ulong
        {
            CRC8 = 0x7,
            CRC16_CCITT = 0x8408,
            CRC16_IBM = 0xA001,
            CRC32 = 0xEDB88320,
            CRC64_ISO = 0xD800000000000000,
            CRC64_ECMA182 = 0xC96C5795D7870F42,
        }

        ulong getSeed()
        {
            switch (poly)
            {
                case Polynomial.CRC8:
                    return 0xff;
                case Polynomial.CRC16_CCITT:
                case Polynomial.CRC16_IBM:
                    return 0xffff;
                case Polynomial.CRC32:
                    return 0xffffffff;
                case Polynomial.CRC64_ISO:
                case Polynomial.CRC64_ECMA182:
                    return 0xffffffffffffffff;
                default:
                    return 0xffffffffffffffff;
            }
        }

        private Polynomial poly;
        private UInt64 hash;
        private UInt64 seed;
        private UInt64[] table;
        //private static UInt64[] defaultTable;

        public CRC(Polynomial polynomial)
        {
            poly = polynomial;
            table = InitializeTable((ulong)polynomial);
            seed = getSeed();
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
            byte[] hashBuffer = UInt64ToBigEndianBytes(~hash);
            this.HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize
        {
            get
            {
                switch (poly)
                {
                    case Polynomial.CRC8:
                        return 8;
                    case Polynomial.CRC16_CCITT:
                    case Polynomial.CRC16_IBM:
                        return 16;
                    case Polynomial.CRC32:
                        return 32;
                    case Polynomial.CRC64_ISO:
                    case Polynomial.CRC64_ECMA182:
                        return 64;
                    default:
                        return 64;
                }
            }
        }

        /*public static UInt64 Compute(byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), DefaultSeed, buffer, 0, buffer.Length);
        }

        public static UInt64 Compute(UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), seed, buffer, 0, buffer.Length);
        }*/

        public static UInt64 Compute(UInt64 polynomial, UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }

        private static UInt64[] InitializeTable(UInt64 polynomial)
        {
            //if (polynomial == DefaultPolynomial && defaultTable != null)
            //    return defaultTable;

            UInt64[] createTable = new UInt64[256];
            for (int i = 0; i < 256; i++)
            {
                UInt64 entry = (UInt64)i;
                for (int j = 0; j < 8; j++)
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                createTable[i] = entry;
            }

            //if (polynomial == DefaultPolynomial)
            //    defaultTable = createTable;

            return createTable;
        }

        private static UInt64 CalculateHash(UInt64[] table, UInt64 seed, byte[] buffer, int start, int size)
        {
            UInt64 crc = seed;
            for (int i = start; i < size; i++)
                unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            return crc;
        }

        private byte[] UInt64ToBigEndianBytes(UInt64 x)
        {
            switch (poly)
            {
                case Polynomial.CRC8:
                    return new byte[] {
                        (byte)(x & 0xff)
                    };
                case Polynomial.CRC16_CCITT:
                case Polynomial.CRC16_IBM:
                    return new byte[] {
                        (byte)((x >> 8) & 0xff),
                        (byte)(x & 0xff)
                    };
                case Polynomial.CRC32:
                    return new byte[] {
                        (byte)((x >> 24) & 0xff),
                        (byte)((x >> 16) & 0xff),
                        (byte)((x >> 8) & 0xff),
                        (byte)(x & 0xff)
                    };
                case Polynomial.CRC64_ISO:
                case Polynomial.CRC64_ECMA182:
                    return new byte[] {
                        (byte)((x >> 56) & 0xff),
                        (byte)((x >> 48) & 0xff),
                        (byte)((x >> 40) & 0xff),
                        (byte)((x >> 32) & 0xff),
                        (byte)((x >> 24) & 0xff),
                        (byte)((x >> 16) & 0xff),
                        (byte)((x >> 8) & 0xff),
                        (byte)(x & 0xff)
                    };
                default:
                    return new byte[] {
                        (byte)((x >> 56) & 0xff),
                        (byte)((x >> 48) & 0xff),
                        (byte)((x >> 40) & 0xff),
                        (byte)((x >> 32) & 0xff),
                        (byte)((x >> 24) & 0xff),
                        (byte)((x >> 16) & 0xff),
                        (byte)((x >> 8) & 0xff),
                        (byte)(x & 0xff)
                    };
            }
        }
    }






    /*
     internal class CRC832 : HashAlgorithm
    {
        public enum CRCbitFeed
        {
            Left,
            Right,
        }

        public enum CRCpolynomial : ulong
        {
            CRC8 = 1 << 7 | 1 << 6 | 1 << 4 | 1 << 2 | 1,
            CRC16 = 1 << 15 | 1 << 2 | 1,
            CRC16_CCITT = 1 << 12 | 1 << 5 | 1,
            CRC32 = 1 << 26 | 1 << 23 | 1 << 22 | 1 << 16 | 1 << 12 | 1 << 11 | 1 << 10 | 1 << 8 | 1 << 7 | 1 << 5 | 1 << 4 | 1 << 2 | 1 << 1 | 1,
        }

        public CRC832(CRCpolynomial poly, CRCbitFeed feed = CRCbitFeed.Right)
        {
            InitialMask = true;
            FinalMask = true;
            Polynomial = (uint)poly;
            BitFeed = feed;

            base.HashSizeValue = (int)Math.Floor(Math.Log(Polynomial) / Math.Log(2F) / 8 + 1) * 8;
            CRCmask = (uint)Math.Pow(2, base.HashSizeValue) - 1;

            CRCtable = new uint[256];

            if (BitFeed == CRCbitFeed.Left)
            {
                CRCpoly = Polynomial;
                uint msb = (uint)(1 << (base.HashSizeValue - 1));

                for (uint i = 0; i < 256; i++)
                {
                    uint c = i << (base.HashSizeValue - 8);
                    for (int j = 0; j < 8; j++)
                        c = (uint)((c << 1) ^ (((c & msb) != 0) ? CRCpoly : 0));
                    CRCtable[i] = c & CRCmask;
                }
            }
            else
            {
                for (int i = 0; i < base.HashSizeValue; i += 4)
                    CRCpoly = (CRCpoly << 4) | Rtbl[(Polynomial >> i) & 0xf];

                for (uint i = 0; i < 256; i++)
                {
                    uint c = i;
                    for (int j = 0; j < 8; j++)
                        c = (c & 1) != 0 ? (CRCpoly ^ (c >> 1)) : (c >> 1);
                    CRCtable[i] = c;
                }
            }

            Initialize();
        }

        uint[] Rtbl = { 0x0, 0x8, 0x4, 0xc, 0x2, 0xa, 0x6, 0xe, 0x1, 0x9, 0x5, 0xd, 0x3, 0xb, 0x7, 0xf };

        bool _InitialMask = false;
        public bool InitialMask
        {
            get
            {
                return _InitialMask;
            }
            set
            {
                _InitialMask = value;
                Initialize();
            }
        }
        public bool FinalMask { get; set; }
        public uint Polynomial { get; private set; }
        public CRCbitFeed BitFeed { get; private set; }

        public int CRCsize
        {
            get { return base.HashSizeValue / 8; }
        }

        byte[] CRCcrc;
        uint LSTvalue;

        uint CRCmask;
        uint CRCvalue;
        uint CRCpoly;
        uint[] CRCtable;

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            unchecked
            {
                while (--cbSize >= 0)
                    CRCvalue = CRCtable[(CRCvalue ^ array[ibStart++]) & 0xff] ^ (CRCvalue >> 8);
            }
            LSTvalue = CRCvalue;
        }

        protected override byte[] HashFinal()
        {
            HashValue = new byte[CRCsize];

            for (uint i = (uint)HashValue.Length, temp = CRCvalue ^ (FinalMask ? CRCmask : 0); i > 0; temp >>= 8)
                HashValue[--i] = (byte)(temp & 0xff);

            return HashValue;
        }

        public override void Initialize()
        {
            CRCvalue = InitialMask ? CRCmask : 0;
        }

        public bool ConsistencyCheck(byte[] crc, byte[] buffer)
        {
            CRCcrc = crc.Reverse().ToArray();
            uint CRCuint = 0;



            CRCvalue = CRCmask;
            ComputeHash(buffer);
            CRCuint = LSTvalue;

            CRCvalue = CRCuint;
            HashCore(CRCcrc, 0, CRCcrc.Length);
            if (CRCvalue == 0)
                return true;

            CRCcrc = CRCcrc.Select(e => (byte)(e ^ 0xff)).ToArray();

            CRCvalue = CRCuint;
            HashCore(CRCcrc, 0, CRCcrc.Length);
            if (CRCvalue == 0)
                return true;



            CRCvalue = 0;
            ComputeHash(buffer);
            CRCuint = LSTvalue;

            CRCvalue = CRCuint;
            HashCore(CRCcrc, 0, CRCcrc.Length);
            if (CRCvalue == 0)
                return true;

            CRCcrc = CRCcrc.Select(e => (byte)(e ^ 0xff)).ToArray();

            CRCvalue = CRCuint;
            HashCore(CRCcrc, 0, CRCcrc.Length);
            if (CRCvalue == 0)
                return true;



            return false;
        }
    }



    public class CRC64 : HashAlgorithm
    {
        public enum Polynomial : ulong
        {
            ISO = 0xD800000000000000,
            ECMA_182 = 0xC96C5795D7870F42,
        }


        public const UInt64 DefaultPolynomial = 0xC96C5795D7870F42;
        public const UInt64 DefaultSeed = 0xffffffffffffffff;

        private UInt64 hash;
        private UInt64 seed;
        private UInt64[] table;
        private static UInt64[] defaultTable;

        public CRC64()
        {
            table = InitializeTable(DefaultPolynomial);
            seed = DefaultSeed;
            Initialize();
        }

        public CRC64(Polynomial polynomial)
        {
            table = InitializeTable((ulong)polynomial);
            seed = DefaultSeed;
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
            byte[] hashBuffer = UInt64ToBigEndianBytes(~hash);
            this.HashValue = hashBuffer;
            return hashBuffer;
        }

        public override int HashSize
        {
            get { return 64; }                                                                                    /////////
        }

        public static UInt64 Compute(byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), DefaultSeed, buffer, 0, buffer.Length);
        }

        public static UInt64 Compute(UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), seed, buffer, 0, buffer.Length);
        }

        public static UInt64 Compute(UInt64 polynomial, UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }

        private static UInt64[] InitializeTable(UInt64 polynomial)
        {
            if (polynomial == DefaultPolynomial && defaultTable != null)
                return defaultTable;

            UInt64[] createTable = new UInt64[256];
            for (int i = 0; i < 256; i++)
            {
                UInt64 entry = (UInt64)i;
                for (int j = 0; j < 8; j++)
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                createTable[i] = entry;
            }

            if (polynomial == DefaultPolynomial)
                defaultTable = createTable;

            return createTable;
        }

        private static UInt64 CalculateHash(UInt64[] table, UInt64 seed, byte[] buffer, int start, int size)
        {
            UInt64 crc = seed;
            for (int i = start; i < size; i++)
                unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            return crc;
        }

        private byte[] UInt64ToBigEndianBytes(UInt64 x)
        {
            return new byte[] {
            (byte)((x >> 56) & 0xff),
            (byte)((x >> 48) & 0xff),
            (byte)((x >> 40) & 0xff),
            (byte)((x >> 32) & 0xff),                                                          ///////////////////
            (byte)((x >> 24) & 0xff),
            (byte)((x >> 16) & 0xff),
            (byte)((x >> 8) & 0xff),
            (byte)(x & 0xff)
        };
        }
    }
     */
}
