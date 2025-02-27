// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
// <OWNER>Microsoft</OWNER>
// 

// MIT License
// https://github.com/microsoft/referencesource/blob/4251daa76e0aae7330139978648fc04f5c7b8ccb/LICENSE.txt
// 
// See NOTICE.md for the full license text.

//
// MACTripleDES.cs -- Implementation of the MAC-CBC keyed hash w/ 3DES
// https://github.com/microsoft/referencesource/blob/4251daa76e0aae7330139978648fc04f5c7b8ccb/mscorlib/system/security/cryptography/mactripledes.cs
//

// See: http://www.itl.nist.gov/fipspubs/fip81.htm for a spec
/*

using System;
using System.IO;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

namespace Hash.Core;

[System.Runtime.InteropServices.ComVisible(true)]
public class MACTripleDES : KeyedHashAlgorithm 
{
    // Output goes to HashMemorySink since we don't care about the actual data
    private ICryptoTransform? m_encryptor;
    private CryptoStream? _cs;
    private TailStream? _ts;
    private const int m_bitsPerByte = 8;
    private int m_bytesPerBlock;
    private TripleDES des;

    //
    // public constructors
    //

    public MACTripleDES() {
        KeyValue = new byte[24];
        Utils.StaticRandomNumberGenerator.GetBytes(KeyValue);

        // Create a TripleDES encryptor
        des = TripleDES.Create();
        HashSizeValue = des.BlockSize;

        m_bytesPerBlock = des.BlockSize/m_bitsPerByte;
        // By definition, MAC-CBC-3DES takes an IV=0.  C# zero-inits arrays,
        // so all we have to do here is define it.
        des.IV = new byte[m_bytesPerBlock];
        des.Padding = PaddingMode.Zeros;

        m_encryptor = null;
    }

    public MACTripleDES(byte[] rgbKey) {
        // Make sure we know which algorithm to use
        if (rgbKey == null)
            throw new ArgumentNullException("rgbKey");
        Contract.EndContractBlock();
        // Create a TripleDES encryptor
        des = TripleDES.Create();

        HashSizeValue = des.BlockSize;
        // Stash the key away
        KeyValue = (byte[]) rgbKey.Clone();

        m_bytesPerBlock = des.BlockSize/m_bitsPerByte;
        // By definition, MAC-CBC-3DES takes an IV=0.  C# zero-inits arrays,
        // so all we have to do here is define it.
        des.IV = new byte[m_bytesPerBlock];
        des.Padding = PaddingMode.Zeros;

        m_encryptor = null;
    }

    public override void Initialize() {
        m_encryptor = null;
    }

    [System.Runtime.InteropServices.ComVisible(false)]
    public PaddingMode Padding {
        get { return des.Padding; }
        set { 
            if ((value < PaddingMode.None) || (PaddingMode.ISO10126 < value))
                throw new CryptographicException("Specified padding mode is not valid for this algorithm.");
            des.Padding = value;
        }
    }

    //  
    // protected methods
    //

    protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) {
        // regenerate the TripleDES object before each call to ComputeHash
        if (m_encryptor == null) {
            des.Key = this.Key;
            m_encryptor = des.CreateEncryptor();
            _ts = new TailStream(des.BlockSize / 8); // 8 bytes
            _cs = new CryptoStream(_ts, m_encryptor, CryptoStreamMode.Write);
        }

        // Encrypt using 3DES
        _cs.Write(rgbData, ibStart, cbSize);
    }

    protected override byte[] HashFinal() {
        // If Hash has been called on a zero buffer
        if (m_encryptor == null) {
            des.Key = this.Key;
            m_encryptor = des.CreateEncryptor();
            _ts = new TailStream(des.BlockSize / 8); // 8 bytes 
            _cs = new CryptoStream(_ts, m_encryptor, CryptoStreamMode.Write);
        }

        // Finalize the hashing and return the result
        _cs.FlushFinalBlock();
        return _ts.Buffer;
    }

    // IDisposable methods
    protected override void Dispose(bool disposing) {
        if (disposing) {
            // dispose of our internal state
            if (des != null)
                des.Clear();
            if (m_encryptor != null)
                m_encryptor.Dispose();
            if (_cs != null)
                _cs.Clear();
            if (_ts != null)
                _ts.Clear();
        }
        base.Dispose(disposing);
    }
}

//
// TailStream is another utility class -- it remembers the last n bytes written to it
// This is useful for MAC-3DES since we need to capture only the result of the last block

internal sealed class TailStream : Stream {
    private byte[]? _Buffer;
    private int _BufferSize;
    private int _BufferIndex = 0;
    private bool _BufferFull = false;

    public TailStream(int bufferSize) {
        _Buffer = new byte[bufferSize];
        _BufferSize = bufferSize;
    }

    public void Clear() {
        Close();
    }

    protected override void Dispose(bool disposing) {
        try {
            if (disposing) {
                if (_Buffer != null) {
                    Array.Clear(_Buffer, 0, _Buffer.Length);
                }
                _Buffer = null;
            }
        }
        finally {
            base.Dispose(disposing);
        }
    }

    public byte[] Buffer {
        get { return (byte[]) _Buffer.Clone(); }
    }

    public override bool CanRead {
        [Pure]
        get { return false; }
    }

    public override bool CanSeek {
        [Pure]
        get { return false; }
    }

    public override bool CanWrite {
        [Pure]
        get { return _Buffer != null; }
    }

    public override long Length {
        get { throw new NotSupportedException("Stream does not support seeking."); }
    }

    public override long Position {
        get { throw new NotSupportedException("Stream does not support seeking."); }
        set { throw new NotSupportedException("Stream does not support seeking."); }
    }

    public override void Flush() {
        return;
    }

    public override long Seek(long offset, SeekOrigin origin) {
        throw new NotSupportedException("Stream does not support seeking.");
    }

    public override void SetLength(long value) {
        throw new NotSupportedException("Stream does not support seeking.");
    }

    public override int Read(byte[] buffer, int offset, int count) {
        throw new NotSupportedException("Stream does not support reading.");
    }

    public override void Write(byte[] buffer, int offset, int count) {
        if (_Buffer == null)
            throw new ObjectDisposedException("TailStream");

        // If no bytes to write, then return
        if (count == 0) return;
        // The most common case will be when we have a full buffer
        if (_BufferFull) {
            // if more bytes are written in this call than the size of the buffer,
            // just remember the last _BufferSize bytes
            if (count > _BufferSize) {
                System.Buffer.BlockCopy(buffer, offset+count-_BufferSize, _Buffer, 0, _BufferSize);
                return;
            } else {
                // move _BufferSize - count bytes left, then copy the new bytes
                System.Buffer.BlockCopy(_Buffer, _BufferSize - count, _Buffer, 0, _BufferSize - count);
                System.Buffer.BlockCopy(buffer, offset, _Buffer, _BufferSize - count, count);
                return;
            }
        } else {
            // buffer isn't full yet, so more cases
            if (count > _BufferSize) {
                System.Buffer.BlockCopy(buffer, offset+count-_BufferSize, _Buffer, 0, _BufferSize);
                _BufferFull = true;
                return;
            } else if (count + _BufferIndex >= _BufferSize) {
                System.Buffer.BlockCopy(_Buffer, _BufferIndex+count-_BufferSize, _Buffer, 0, _BufferSize - count);
                System.Buffer.BlockCopy(buffer, offset, _Buffer, _BufferIndex, count);
                _BufferFull = true;
                return;
            } else {
                System.Buffer.BlockCopy(buffer, offset, _Buffer, _BufferIndex, count);
                _BufferIndex += count;
                return;
            }
        }
    }
}

// Utils.cs
internal static partial class Utils
{
    // https://github.com/microsoft/referencesource/blob/4251daa76e0aae7330139978648fc04f5c7b8ccb/mscorlib/system/security/cryptography/utils.cs#L495-L502

    private static volatile RandomNumberGenerator? _rng;
    internal static RandomNumberGenerator StaticRandomNumberGenerator {
        get {
            if (_rng == null)
                _rng = RandomNumberGenerator.Create();
            return _rng;
        }
    }
}
*/
