# HashCalculator [v0.7.0]  

ファイルのハッシュを計算できます。  
また、ファイルを右クリックしてHash for ContextMenu(F)をクリックし、  
アルゴリズムを選択または*をクリックするとそのファイルのハッシュを計算できます。

## 対応ハッシュアルゴリズム  
・MD5  
  
・SHA1  
・SHA256  
・SHA384  
・SHA512  
  
・SHA3-256 *2  
・SHA3-384 *2  
・SHA3-512 *2  
  
・CRC8 *1  
・CRC16-CCITT  
・CRC16-IBM *1  
・CRC32  
・CRC32C *1  
・CRC64-ECMA  
・CRC64-ISO *1  
・CRC64-XZ *3  
  
・RIPEMD160 *1  
  
・xxHash32 *1  
・xxHash64 *1  
・xxHash3  
・xxHash128 *1  
  
*1 選択ボックスに直接入力  
*2 Windows11 24H2以降のみ  
*3 XZ Utilsの実装(7-Zip等が使用)と同じ

## 動作確認  
Windows11 Pro 23H2 x86_64  
.NET Desktop Runtime 8.0.11
