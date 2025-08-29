# winapp_convert_heic_to_png

![convet_heic_to_png v1.0.0](https://img.shields.io/badge/convet_heic_to_png-v1.0.0-6479ff.svg)

WindowsのHEICの画像ファイルを右クリックで、画像を変換できるようにするツールです。

## 機能
- iPhoneなどの写真で使われるHEIC形式(*.HEIC)の画像をPNG形式(*.PNG)に変換します。
- 画像ファイルを右クリックし、コンテキストメニューから「HEIC→PNG」を選択するだけで変換が実行されます。
- 主に、TwitterなどSNS用に数枚の写真をHEICからPNGに変換してアップロードするような用途を想定しています。
- 大量の写真を一括で変換する用途には向いていません。

## インストール

1. `C:\usr\convert_heic_to_png` というディレクトリを作成します。
2. 以下のファイルを、作成した `C:\usr\convert_heic_to_png` ディレクトリに配置します。
    - `convert_heic_to_png.exe`
    - `HEIC2PNG.bat`
    - `Magick.Native-Q8-x64.dll`
    - `setup.inf`
3. `setup.inf` ファイルを右クリックし、「インストール」を選択します。
4. これで、右クリックメニューに「HEIC→PNG」が追加されます。

## 使い方

1. 変換したいHEICファイル（`.heic`）を右クリックします。
2. メニューから「HEIC→PNG」を選択します。
3. 同じフォルダにPNGファイル（`.png`）が作成されます。

## 実装について

- このツールはC#で作成されたコンソールアプリケーションです。
- 画像の変換処理には、[ImageMagick](https://imagemagick.org/) ライブラリを使用しています。
- 右クリックメニューへの登録は、`setup.inf` によってWindowsレジストリに設定を追加することで実現しています。

## アンインストール

1. 「設定」 > 「アプリ」 > 「アプリと機能」を開きます。
2. 「HEIC2PNG」を探して選択し、「アンインストール」をクリックします。
   （もし見つからない場合は、コントロールパネルの「プログラムのアンインストール」からも同様に削除できます）
3. `C:\usr\convert_heic_to_png` ディレクトリを手動で削除してください。