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
バーコードの読み取りに成功すると、CSVファイルおよびクリップボードにバーコード情報が保存されます。（設定により動作が異なります）
![BarcodeReaderSample_image2](https://user-images.githubusercontent.com/45218829/90587512-86fa5f00-e214-11ea-86ce-58f8f6da4a93.png)
　
- 各種設定  
コンテキストメニューの「Settings」を選択して設定フォームを表示します。  
設定フォームには以下の設定メニューがあります。  
  - 使用するカメラの選択
  - 読み取ったバーコード情報をCSVファイルに保存するかどうか
    - CSVファイルの作成先ディレクトリ  
  - 読み取ったバーコード情報をクリップボードに保存するかどうか

  ![BarcodeReaderSample_image4](https://user-images.githubusercontent.com/45218829/90850967-39195e80-e3ae-11ea-9b20-b9f1ace2e3ba.png)

#### ライセンス
MIT





