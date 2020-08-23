## BarcodeReader サンプル
PCカメラを使ってバーコードを読み取るアプリのサンプルです。  
![BarcodeReaderSample_image1](https://user-images.githubusercontent.com/45218829/90317915-94d78800-df67-11ea-9d15-80aedcc9213f.png)

#### プラットフォーム

|Platform|Version|
| -------------------  | :------------------: |
|.NET Framework|4.7.1|

#### Framework

|Framework|
| -------------------  |
|Windows Forms|

#### セットアップ
* [VisualStudio2019](https://visualstudio.microsoft.com/ja/downloads/)のインストール(インストーラーで「.NETデスクトップ開発」を選択)
* [.NET Framework 4.7.1](https://dotnet.microsoft.com/download/dotnet-framework/net471)のインストール
* プロジェクトファイルをクローンまたはダウンロードしてビルド

#### アプリの機能
- バーコード リーダー  
コンテキストメニューから「Start barcode scanning」を選択するとカメラが起動し、バーコードの読み取りを待機します。  
バーコードの読み取りに成功すると、CSVファイルにバーコード情報が保存されます。
![BarcodeReaderSample_image2](https://user-images.githubusercontent.com/45218829/90587512-86fa5f00-e214-11ea-86ce-58f8f6da4a93.png)
　
- 各種設定  
コンテキストメニューの「Settings」を選択して設定フォームを表示します。  
設定フォームには以下の設定メニューがあります。  
  - 使用するカメラの選択
  - 読み取ったバーコード情報を保存するCSVファイルの作成先ディレクトリ  

  ![BarcodeReaderSample_image3](https://user-images.githubusercontent.com/45218829/90587531-95e11180-e214-11ea-8689-ddd1dff3cf16.png)

#### ライセンス
MIT




