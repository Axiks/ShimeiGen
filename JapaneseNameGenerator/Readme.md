# Shimei Generator

With this library you can generate Japanese names and surnames
The program allows you to display a name or surname in Romanji or Kanji style!

## Example of use
```
ShimeiGenerator jpGenerator = new ShimeiGenerator();

Person person = await jpGenerator.GetRandomPerson();
Console.WriteLine($"{ person.RomanjiFullName } : {person.KanjiFullName} : {person.Sex}");
```

## Examples of generations
```
shinkei kannumata : 伸啓 菅沼田 : M

yonezou asanami : 米造 浅浪 : M

juu akirajou : 十 明定 : M

shigeji nichinishi : 繁二 日西 : M

shimako futofu : 志摩子 太附 : F

yuu chimura : 郁哉 千村 : M

noriyuki tsubosakae : 典幸 坪栄 : M

hatsushou  : 初称 摘田 : F

nashihisashikei shuuzan : 梨央佳 秀山 : F

sakisenshi nakadomari : 咲千子 中泊 : F

e ariyoshi : 絵璃奈 有吉 : F

rakukou konmachi : 楽光 今待 : M

akiminoru tsuneshigeru : 秋実 恒成 : F

junsei motomura : 淳生 元村 : M

yuuhate ishikou : 悠果 石幸 : F

kokoroaoi imae : 心葵 今江 : F

akiramei miyanaga : 照名 宮永 : F

kaoru kanae : 馨 鼎 : F

kairiisago sanmen : 浬沙 三綿 : F

rinhana kenjou : 凛花 兼上 : F

chokuhisashikei shouichihara : 直央佳 小一原 : F

miosaki aoka : 澪咲 蒼下 : F

nisshi takehajime : 莉日子 武元 : F

nashigo shinsako : 梨子 新佐古 : F

yoshi chuushouji : 芳乃 中庄司 : F

mitsuyoshi take : 光喜 竹嶌 : M

rikuwataru kamofuji : 陸弥 鴨藤 : M

yuuki yumirin : 裕樹 弓林 : F

ikue fukaka : 育恵 深家 : F

bishoku wadahama : 美色 和田浜 : F

tsuyoou ishuku : 強王 居宿 : M

toshio tsuneyasu : 俊郎 常安 : M

kouichi  : 滉一 綜村 : F

aoimiyako sakontakashi : 蒼都 左近充 : M

hisaon tairai : 久音 平伊 : M

natsuhi daiiida : 夏妃 大飯田 : F

ryuukuni kinchika : 龍邦 金近 : M

yoshiyume hachiyaku : 美夢 八役 : F

masaji onikyou : 正路 鬼京 : M

takako shounemori : 喬子 小根森 : F

seiichirou uno : 静一郎 売野 : M

toorukokorozashi okanami : 徹志 岡並 : M

yoshinori uzuoka : 嘉紀 渦岡 : M

hiyosato hiroshita : 陽世里 博田 : F

ryouni fujikyo : 遼二 富士居 : M

yuuhana chou : 悠華 長添 : F

tooruyuu kuni : 暢雄 国鞆 : M

kiyoshibun hanahiraku : 聖文 花開 : M

tsubuseman ougisha : 拓万 扇舎 : M

ainagisa konsawa : 愛渚 紺沢 : F

mizunoesoku kanou : 壬則 過能 : M

kazu oozu : 和倖 大図 : M

hatsuno  : 初乃 栽松 : F

tsugumi ikeuo : 二美 活魚 : F

saitsumi uchihiro : 菜津実 内広 : F

toshihiko iehora : 敏彦 家洞 : M

junuta saiken : 純歌 才兼 : F
```

## Used libraries and dependencies
* Used [JapaneseNamesDatabase](https://github.com/jackdeguest/JapaneseNamesDatabase) to receive names, surnames and other metadata
* Used [Kawazu](https://github.com/Cutano/Kawazu) to convert Kanji name to Romanji style
* Used [.NET日本語形態素解析エンジンNMeCab](https://github.com/komutan/NMeCab/tree/master) dictonary to work with [Kawazu](https://github.com/Cutano/Kawazu)