# 共通仕様書

## アカウントについて
### アカウント名
- 1文字以上10文字以下
- 半角/全角英数字と日本語のみで構成される必要がある
- 正規表現では以下の感じ
```
regexp = [0-9０-９a-zA-Zぁ-んァ-ヶｱ-ﾝﾞﾟ一-龠]{1,10}
```

## 認証について
### AuthToken
- ユーザー登録時に返却され、端末にずっと保存される
- 基本的に変更はされない
- password 的な位置付け

### SessionToken
- 認証が必要なリクエストには、一時的な認証トークンである SessionToken を持たせる
- UserID・AuthToken をサーバーに投げると、その User の SessionToken が帰ってくる
- SessionToken には有効期限があり、その期限はサーバー側に保管されている
- もし今まで使っていた SessionToken の有効期限が切れて認証できなくなったら(StatusCode401)上記方法で新しい SessionToken を生成し、それを使い再度リクエストする
