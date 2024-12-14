# HashCalculator [v0.6.2]  
  
Hash計算機でHashを計算できます。  
また、ファイルを右クリックしてHash for ContextMenu(F)をクリックし、  
Hashを選択または*をクリックするとそのファイルのHashを計算できます。  
  
対応Hashアルゴリズム  
・MD5  
  
・SHA1  
・SHA256  
・SHA384  
・SHA512  
  
・SHA3-256 \*2  
・SHA3-384 \*2  
・SHA3-512 \*2  
  
・CRC8 \*1  
・CRC16-CCITT  
・CRC16-IBM \*1  
・CRC32  
・CRC32C \*1  
・CRC64-ECMA  
・CRC64-ISO \*1  
・CRC64-XZ \*3  
  
・RIPEMD160 \*1  
  
・xxHash32 \*1  
・xxHash64 \*1  
・xxHash3  
・xxHash128 \*1  
  
*1 選択ボックスに直接入力  
*2 Windows11 24H2以降のみ  
*3 XZ Utilsの実装(7-Zip等が使用)と同じ  
  
動作確認  
Windows11 Pro 23H2 x86_64  
.NET Desktop Runtime 8.0.10  
  
更新予定: WPF,WinUI3(Windows App SDK)への移行  
  
更新履歴  
Ver.β0.1.1 初版  
Ver.β0.2.0 HashForContextを追加 Installerを新しく。  
Ver.β0.3.0 .NET Framework 4.7.2 -> 4.8  + メンテナンス  
v0.4.0-alpha バージョン表記を変更 + Hash.exeとHashForContext.exeを統一 + バグ修正  
v0.5.0-alpha Hashアルゴリズムを追加(CRC系統・MACTripleDES・RIPEMD160)  
             + 大文字・ハイフンオプションを追加 + バグ修正 + メンテナンス  
v0.5.1-alpha 設定の"HashForContextを有効にする"が正常に動作しない問題を修正  
v0.5.2-alpha ライセンスの表示を修正 GitHubへのリンクを更新  
v0.5.3 alpha表記を削除 GitHubへのリンクを更新  
v0.5.4 ファイルサイズを削減 一部表記変更  
v0.6.0 .NET8へ移行 MACTripleDESを削除 CRC32Cを追加 その他バグ修正  
v0.6.1 arm64及びx86版を追加 その他細かい変更・修正  
v0.6.2 xxHashを追加 24H2上でSHA3を追加 アイコンを追加 その他変更・修正  
