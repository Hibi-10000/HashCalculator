using System;
using System.IO;
using System.Security.Cryptography;

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
            CRC8,
            CRC16_IBM,
            CRC16_CCITT,
            CRC32,
            CRC64_ECMA,
            CRC64_ISO,
            MACTripleDES,
            RIPEMD160,
        }

        public static HashType HashTypeFromString(string value) {
            return (HashType)Enum.Parse(typeof(HashType), value.Replace("-", "_"));
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
                //case HashType.CRC8:
                //    hashProvider = new CRC(CRC.Polynomial.CRC8);
                //    break;
                case HashType.CRC16_IBM:
                    hashProvider = new CRC(CRC.Polynomial.CRC16_IBM);
                    break;
                case HashType.CRC16_CCITT:
                    hashProvider = new CRC(CRC.Polynomial.CRC16_CCITT);
                    break;
                case HashType.CRC32:
                    hashProvider = new CRC(CRC.Polynomial.CRC32);
                    break;
                case HashType.CRC64_ECMA:
                    hashProvider = new CRC(CRC.Polynomial.CRC64_ECMA);
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
            //var fs = new MemoryStream(System.Text.Encoding.ASCII.GetBytes("123456789"));
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
            CRC64_ECMA = 0xC96C5795D7870F42,
            CRC64_ISO = 0xD800000000000000,
        }

        ulong GetSeed()
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
                case Polynomial.CRC64_ECMA:
                case Polynomial.CRC64_ISO:
                    return 0xffffffffffffffff;
                default:
                    return 0xffffffffffffffff;
            }
        }

        private readonly Polynomial poly;
        private ulong hash;
        private readonly ulong seed;
        private readonly ulong[] table;
        //private static ulong[] defaultTable;

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
                switch (poly)
                {
                    case Polynomial.CRC8:
                        return 8;
                    case Polynomial.CRC16_CCITT:
                    case Polynomial.CRC16_IBM:
                        return 16;
                    case Polynomial.CRC32:
                        return 32;
                    case Polynomial.CRC64_ECMA:
                    case Polynomial.CRC64_ISO:
                        return 64;
                    default:
                        return 64;
                }
            }
        }

        /*public static ulong Compute(byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), DefaultSeed, buffer, 0, buffer.Length);
        }

        public static ulong Compute(ulong seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), seed, buffer, 0, buffer.Length);
        }

        public static ulong Compute(ulong polynomial, ulong seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }*/

        private static ulong[] InitializeTable(ulong polynomial)
        {
            //if (polynomial == DefaultPolynomial && defaultTable != null)
            //    return defaultTable;

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

            //if (polynomial == DefaultPolynomial)
            //    defaultTable = createTable;

            return createTable;
        }

        private static ulong CalculateHash(ulong[] table, ulong seed, byte[] buffer, int start, int size)
        {
            ulong crc = seed;
            for (int i = start; i < size; i++)
                unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            return crc;
        }

        private byte[] ULongToBigEndianBytes(ulong x)
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
                case Polynomial.CRC64_ECMA:
                case Polynomial.CRC64_ISO:
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
}
