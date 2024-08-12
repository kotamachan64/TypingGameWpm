using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    internal class Japanese : Launguage
    {
        /// <summary>
        ///ローマ字に変換するマップ。 
        /// </summary>
        private static Dictionary<string, string[]> japaneseMap = new Dictionary<string, string[]>()
        {
            { "あ", ["a"] }, { "い", ["i", "yi"] }, { "う", ["u", "wu", "whu"] }, { "え", ["e"] }, { "お", ["o"] },
            { "か", ["ka", "ca"] }, { "き", ["ki"] }, { "く", ["ku", "cu", "qu"] }, { "け", ["ke"] }, { "こ", ["ko", "co"] },
            { "さ", ["sa"] }, { "し", ["si", "shi", "ci"] }, { "す", ["su"] }, { "せ", ["se", "ce"] }, { "そ", ["so"] },
            { "た", ["ta"] }, { "ち", ["ti", "chi"] }, { "つ", ["tu", "tsu"] }, { "て", ["te"] }, { "と", ["to"] },
            { "な", ["na"] }, { "に", ["ni"] }, { "ぬ", ["nu"] }, { "ね", ["ne"] }, { "の", ["no"] },
            { "は", ["ha"] }, { "ひ", ["hi"] }, { "ふ", ["hu", "fu"] }, { "へ", ["he"] }, { "ほ", ["ho"] },
            { "ま", ["ma"] }, { "み", ["mi"] }, { "む", ["mu"] }, { "め", ["me"] }, { "も", ["mo"] },
            { "や", ["ya"] }, { "ゆ", ["yu"] }, { "よ", ["yo"] },
            { "ら", ["ra"] }, { "り", ["ri"] }, { "る", ["ru"] }, { "れ", ["re"] }, { "ろ", ["ro"] },
            { "わ", ["wa"] }, { "を", ["wo"] }, { "ん", ["n", "nn", "xn"] },
            { "が", ["ga"] }, { "ぎ", ["gi"] }, { "ぐ", ["gu"] }, { "げ", ["ge"] }, { "ご", ["go"] },
            { "ざ", ["za"] }, { "じ", ["zi", "ji"] }, { "ず", ["zu"] }, { "ぜ", ["ze"] }, { "ぞ", ["zo"] },
            { "だ", ["da"] }, { "ぢ", ["di"] }, { "づ", ["du"] }, { "で", ["de"] }, { "ど", ["do"] },
            { "ば", ["ba"] }, { "び", ["bi"] }, { "ぶ", ["bu"] }, { "べ", ["be"] }, { "ぼ", ["bo"] },
            { "ぱ", ["pa"] }, { "ぴ", ["pi"] }, { "ぷ", ["pu"] }, { "ぺ", ["pe"] }, { "ぽ", ["po"] },
            { "きゃ", ["kya"] }, { "きゅ", ["kyu"] }, { "きょ", ["kyo"] },
            { "しゃ", ["sya", "sha"] }, { "しゅ", ["syu", "shu"] }, { "しょ", ["syo", "sho"] },
            { "ちゃ", ["tya", "cya", "cha"] }, { "ちゅ", ["tyu", "cyu", "chu"] }, { "ちょ", ["tyo", "cyo", "cho"] },
            { "にゃ", ["nya"] }, { "にゅ", ["nyu"] }, { "にょ", ["nyo"] },
            { "ひゃ", ["hya"] }, { "ひゅ", ["hyu"] }, { "ひょ", ["hyo"] },
            { "みゃ", ["mya"] }, { "みゅ", ["myu"] }, { "みょ", ["myo"] },
            { "りゃ", ["rya"] }, { "りゅ", ["ryu"] }, { "りょ", ["ryo"] },
            { "ぎゃ", ["gya"] }, { "ぎゅ", ["gyu"] }, { "ぎょ", ["gyo"] },
            { "じゃ", ["zya", "ja", "jya"] }, { "じゅ", ["zyu", "ju", "jyu"] }, { "じょ", ["zyo", "jo", "jyo"] },
            { "ぢゃ", ["dya"] }, { "ぢゅ", ["dyu"] }, { "ぢょ", ["dyo"] },
            { "でゃ", ["dha"] }, { "でゅ", ["dhu"] }, { "でょ", ["dho"] },
            { "びゃ", ["bya"] }, { "びゅ", ["byu"] }, { "びょ", ["byo"] },
            { "ぴゃ", ["pya"] }, { "ぴゅ", ["pyu"] }, { "ぴょ", ["pyo"] },
            { "ゃ", ["lya", "xya"] }, { "ゅ", ["lyu", "xyu"] }, { "ょ", ["lyo", "xyo"] },
            { "っ", ["ltu", "ltsu", "xtu", "xtsu"] },
            { "ー", ["-"] }
        };

        /// <summary>
        /// タイピングテキストをローマ字に変換し、配列にする。
        /// </summary>
        /// <param name="kana">タイピングテキスト。</param>
        /// <returns>ローマ字に変換し、配列にしたもの。returns = [found = [""]]</returns>
        public static IEnumerable<string[]> ConvertToAlpha(string kana)
        {
            return kana.ToCharArray().Select(c =>
            {
                var found = japaneseMap
                    .Keys
                    .Where(key => key == c.ToString())
                    .Select(key => japaneseMap[key])
                    .First();
                return found;
            }).ToArray();
        }

        /// <summary>
        /// alpha配列の「ん」や拗音や促音の打ち分けの微調整をする。
        /// </summary>
        /// <param name="alpha">alpha = [c = [""]]</param>
        /// <returns>alpha配列を微調整した配列。</returns>
        public static IEnumerable<string[]> AlphaAdjustment(string[][] alpha)
        {
            string[] consonantN = { "a", "i", "u", "e", "o", "na", "ni", "nu", "ne", "no", "n" };
            for (int i = 0; i < alpha.Length; i++)
            {
                var inspecting = alpha[i];
                //次の文字が存在する場合。
                if (i < alpha.Length - 1)
                {
                    //「ん」が現在の文字であり、次の文字の子音がNである場合。
                    if (inspecting[0] == "n" && consonantN.Contains(alpha[i + 1][0]))
                    {
                        //配列内からN以外のものだけの配列にし、削除する動作。
                        alpha[i] = inspecting.Where(a => a.ToString() != "n").ToArray();
                    }
                    //次の文字が小文字の場合
                    if (alpha[i + 1].Where(kana => kana[0].ToString() == "l").Any())
                    {
                        var twoCharacter = japaneseMap.FirstOrDefault(obj => obj.Key == japaneseMap.FirstOrDefault(obj => obj.Value == alpha[i]).Key + japaneseMap.FirstOrDefault(obj => obj.Value == alpha[i + 1]).Key).Value;
                        var index1 = 0;
                        var index2 = 0;
                        var result = new List<string> { };
                        while (true)
                        {
                            if (index1 == alpha[i].Length)
                            {
                                index1 = 0;
                                index2++;
                            }
                            if (index2 == alpha[i + 1].Length)
                            {
                                break;
                            }
                            result.AddRange(new string[] { alpha[i][index1] + alpha[i + 1][index2] });
                            index1++;
                        }
                        result.AddRange(twoCharacter);
                        alpha = alpha.Where(c => c != alpha[i + 1]).ToArray();
                        alpha[i] = result.ToArray();
                    }
                }
            }
            return alpha;
        }

        public Japanese(string[][] alpha) : base(alpha)
        {
        }

        /// <summary>
        /// プレイヤーが入力したキーがJapaneseMapで変換した配列に含まれているかの判定。
        /// </summary>
        /// <param name="input">プレイヤーが入力したキー。</param>
        /// <returns>文字を入力し終えたか、打てたか、ミスしたかの列挙型の判定結果。</returns>
        public override DetectResult Detect(string progress, ConsoleKeyInfo input, int alphaIndex, int characterIndex)
        {
            var inputString = progress + input.Key.ToString().ToLower();
            //文章を打ち終わっていない場合。
            if (alpha.Length > alphaIndex)
            {
                var found = alpha[alphaIndex].Where(text => text.StartsWith(inputString));
                //今打っているのが正しいかの判断。
                if (found.Any())
                {
                    //全部打ち終えたかの判定。
                    if (alphaIndex == alphaLastIndex && found.ToArray().Where(alpha => alpha.Length - 1 == characterIndex).Any())
                    {
                        return DetectResult.AllClear;
                    }
                    //一文字打ち終えたかの判定。
                    if (found.ToArray().Where(kana => kana == inputString).Any())
                    {
                        return DetectResult.OK;
                    }
                    return DetectResult.Clear;
                }
            }
            return DetectResult.NG;
        }
    }
}
