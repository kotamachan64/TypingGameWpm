using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    internal class Question
    {
#pragma warning disable CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。
        public string TypingText {  get; private set; }
        public string KanaText { get; private set; }
#pragma warning restore CS8618 // null 非許容のフィールドには、コンストラクターの終了時に null 以外の値が入っていなければなりません。Null 許容として宣言することをご検討ください。
        public static Question[] Questions = new Question[]
        {
            /*new Question(){ TypingText = "先生の口癖", KanaText = "せんせいのくちぐせ" },
            new Question(){ TypingText = "高校生", KanaText = "こうこうせい" },
            new Question(){ TypingText = "急がば回れ", KanaText = "いそがばまわれ" },
            new Question(){ TypingText = "大学生", KanaText = "だいがくせい" },
            new Question(){ TypingText = "全国大会開催", KanaText = "ぜんこくたいかいかいさい" },
            new Question(){ TypingText = "ありがとうございます", KanaText = "ありがとうございます" },*/
            new Question(){ TypingText = "小学生", KanaText = "しょうがくせい" },
            new Question(){ TypingText = "中学生", KanaText = "ちゅうがくせい" },
            //new Question(){ TypingText =  "超常現象", KanaText = "ちょうじょうげんしょう" }
            /*new Question(){ TypingText = "山", KanaText = "やま" },
            new Question(){ TypingText = "谷", KanaText = "たに" },
            new Question(){ TypingText = "丘", KanaText = "おか" },
            new Question(){ TypingText = "海", KanaText = "うみ" },
            new Question(){ TypingText = "雲", KanaText = "くも" },
            new Question(){ TypingText = "虫", KanaText = "むし" },
            new Question(){ TypingText = "花", KanaText = "はな" },
            new Question(){ TypingText = "車", KanaText = "くるま" },
            new Question(){ TypingText = "首", KanaText = "くび" },
            new Question(){ TypingText = "手", KanaText = "て" },
            new Question(){ TypingText = "権利", KanaText = "けんり" },*/
            /*new Question(){ TypingText = "交渉", KanaText = "こうしょう" },
            new Question(){ TypingText = "余地", KanaText = "よち" },
            new Question(){ TypingText = "最強", KanaText = "さいきょう" },
            new Question(){ TypingText = "省略", KanaText = "しょうりゃく" },
            new Question(){ TypingText = "金閣", KanaText = "きんかく" },
            new Question(){ TypingText = "銀閣", KanaText = "ぎんかく" },
            new Question(){ TypingText = "参照", KanaText = "さんしょう" },
            new Question(){ TypingText = "終了", KanaText = "しゅうりょう" },
            new Question(){ TypingText = "小学生", KanaText = "しょうがくせい" },
            new Question(){ TypingText = "中学生", KanaText = "ちゅうがくせい" },
            new Question(){ TypingText = "高学生", KanaText = "こうこうせい" },
            new Question(){ TypingText = "大学生", KanaText = "だいがくせい" },
            new Question(){ TypingText = "誕生日", KanaText = "たんじょうび" },
            new Question(){ TypingText = "唐辛子", KanaText = "とうがらし" },
            new Question(){ TypingText = "展覧会", KanaText = "てんらんかい" },
            new Question(){ TypingText = "感情的", KanaText = "かんじょうてき" },
            new Question(){ TypingText = "三原色", KanaText = "さんげんしょく" },
            new Question(){ TypingText = "登竜門", KanaText = "とうりゅうもん" },
            new Question(){ TypingText = "出席番号", KanaText = "しゅっせきばんごう" },
            new Question(){ TypingText = "超常現象", KanaText = "ちょうじょうげんしょう" },
            new Question(){ TypingText = "地域社会", KanaText = "ちいきしゃかい" },
            new Question(){ TypingText = "焼肉定食", KanaText = "やきにくていしょく" },
            new Question(){ TypingText = "七転八起", KanaText = "しちてんはっき" },
            new Question(){ TypingText = "四字熟語", KanaText = "よじじゅくご" },
            new Question(){ TypingText = "宇宙飛行士", KanaText = "うちゅうひこうし" },
            new Question(){ TypingText = "学級委員会", KanaText = "がっきゅういいんかい" },
            new Question(){ TypingText = "障害物競走", KanaText = "しょうがいぶつきょうそう" },
            new Question(){ TypingText = "天気予報士", KanaText = "てんきよほうし" },
            new Question(){ TypingText = "運指最適化", KanaText = "うんしさいてきか" },
            new Question(){ TypingText = "運命共同体", KanaText = "うんめいきょうどうたい" },
            new Question(){ TypingText = "得手不得手", KanaText = "えてふえて" },
            new Question(){ TypingText = "五十歩百歩", KanaText = "ごじっぽひゃっぽ" },
            new Question(){ TypingText = "日本国憲法", KanaText = "にほんこくけんぽう" },
            new Question(){ TypingText = "特定外来生物", KanaText = "とくていがいらいせいぶつ" },
            new Question(){ TypingText = "大腸菌感染症", KanaText = "だいちょうきんかんせんしょう" },
            new Question(){ TypingText = "千夜一夜物語", KanaText = "せんやいちやものがたり" },
            new Question(){ TypingText = "情報発信技術", KanaText = "じょうほうはっしんぎじゅつ" },
            new Question(){ TypingText = "日米和親条約", KanaText = "にちべいわしんじょうやく" },
            new Question(){ TypingText = "放送禁止用語", KanaText = "ほうそうきんしようご" },
            new Question(){ TypingText = "国際連盟脱退", KanaText = "こくさいれんめいだったい" },
            new Question(){ TypingText = "一般社会法人", KanaText = "いっぱんしゃかいほうじん" },
            new Question(){ TypingText = "一般相対性理論", KanaText = "いっぱんそうたいせいりろん" },
            new Question(){ TypingText = "東京特許許可局", KanaText = "とうきょうとっきょきょかきょく" },
            new Question(){ TypingText = "中華人民共和国", KanaText = "ちゅうかじんみんきょうわこく" },
            new Question(){ TypingText = "開発者専用機能", KanaText = "かいはつしゃせんようきのう" },
            new Question(){ TypingText = "超高難度問題集", KanaText = "ちょうこうなんどもんだいしゅう" },
            new Question(){ TypingText = "腸管出血性大腸菌", KanaText = "ちょうかんしゅっけつせい" },
            new Question(){ TypingText = "超難問高校入試問題", KanaText = "ちょうなんもんこうこうにゅうしもんだい" },
            new Question(){ TypingText = "腸管出血性大腸菌感染症", KanaText = "ちょうかんしゅっけつせいだいちょうきんかんせんしょう" },
            new Question(){ TypingText = "ファイト", KanaText = "ふぁいと" },
            new Question(){ TypingText = "ショットガン", KanaText = "しょっとがん" },
            new Question(){ TypingText = "三脚カメラ", KanaText = "さんきゃくかめら" },
            new Question(){ TypingText = "高級キーボード", KanaText = "こうきゅうきーぼーど" },
            new Question(){ TypingText = "賞金稼ぎ", KanaText = "しょうきんかせぎ" },
            new Question(){ TypingText = "プールサイド", KanaText = "ぷーるさいど" },
            new Question(){ TypingText = "地域の行事", KanaText = "ちいきのぎょうじ" },
            new Question(){ TypingText = "ポイント稼ぎ", KanaText = "ぽいんとかせぎ" },
            new Question(){ TypingText = "アンケート", KanaText = "あんけーと" },
            new Question(){ TypingText = "影響される", KanaText = "えいきょうされる" },*/
        };
        public static Question Ask()
        {
            return Questions[new Random().Next(Questions.Length)];
        }
    }
}
