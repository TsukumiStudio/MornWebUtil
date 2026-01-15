# MornWebUtil

## 概要

WebGLビルド上でURLをブラウザで開くためのユーティリティライブラリ。

## 依存関係

| 種別 | 名前 |
|------|------|
| 外部パッケージ | なし |
| Mornライブラリ | なし |

## 使い方

### 直接API使用

```csharp
MornWebUtil.Open("https://example.com");
```

### UIボタン経由

ButtonコンポーネントにMornWebOpenURLButtonスクリプトをアタッチし、`_url`フィールドにURLを設定します。

### プラットフォーム別動作

| プラットフォーム | 動作 |
|-----------------|------|
| WebGL | JavaScript の `window.open()` を呼び出し |
| エディタ | `System.Diagnostics.Process.Start()` で開く |
| その他 | ログ出力のみ |
