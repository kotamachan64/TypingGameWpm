using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    internal class KanaJapanese : Launguage
    {
        private static Dictionary<string, ConsoleKeyInfo> japaneseMap = new Dictionary<string, ConsoleKeyInfo>()
        {
            { "あ", new ConsoleKeyInfo('a',ConsoleKey.D3,false,false,false) },
            { "い", new ConsoleKeyInfo('e', ConsoleKey.E,false,false,false) },
            { "う", new ConsoleKeyInfo('4', ConsoleKey.D4,false,false,false) },
            { "え", new ConsoleKeyInfo('5', ConsoleKey.D5,false,false,false) },
            { "お", new ConsoleKeyInfo('6', ConsoleKey.D6,false,false,false) },
            { "か", new ConsoleKeyInfo('t', ConsoleKey.T,false,false,false) },
            { "き", new ConsoleKeyInfo('g', ConsoleKey.G,false,false,false) },
            { "く", new ConsoleKeyInfo('h', ConsoleKey.H,false,false,false) },
            { "け", new ConsoleKeyInfo(':', ConsoleKey.OemComma,false,false,false) }
            /*{ "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },
            { "", new ConsoleKeyInfo('', ConsoleKey.,,false,false) },/*, { "い", "e" }, { "う", "d4" }, { "え", "d5" }, { "お", "d6" },
            { "か", "t" }, { "き", "g" }, { "く", "h" }, { "け", ":" }, { "こ", "b" },
            { "さ", "x" }, { "し", "d" }, { "す", "r" }, { "せ", "p" }, { "そ", "c" },
            { "た", "q" }, { "ち", "a" }, { "つ", "z" }, { "て", "w" }, { "と", "s" },
            { "な", "u" }, { "に", "i" }, { "ぬ", "d1" }, { "ね", "," }, { "の", "k" },
            { "は", "f" }, { "ひ", "v" }, { "ふ", "2" }, { "へ", "^" }, { "ほ", "-" },
            { "ま", "j" }, { "み", "n" }, { "む", "]" }, { "め", "" }, { "も", "m" },
            { "や", "d7" }, { "ゆ", "d8" }, { "よ", "d9" },
            { "ら", "o" }, { "り", "l" }, { "る", "." }, { "れ", ";" }, { "ろ", "\\" },
            { "わ", "d0" }, { "を", "Shiftd0" }, { "ん", "y" },
            { "が", "t@" }, { "ぎ", "g@" }, { "ぐ", "h@" }, { "げ", ":@" }, { "ご", "b@" },
            { "ざ", "x@" }, { "じ", "d@" }, { "ず", "r@" }, { "ぜ", "p@" }, { "ぞ", "c@" },
            { "だ", "q@" }, { "ぢ", "a@" }, { "づ", "z@" }, { "で", "w@" }, { "ど", "s@" },
            { "ば", "f@" }, { "び", "v@" }, { "ぶ", "2@" }, { "べ", "^@" }, { "ぼ", "-@" },
            { "ぱ", "f[" }, { "ぴ", "v[" }, { "ぷ", "2[" }, { "ぺ", "^[" }, { "ぽ", "-[" },
            { "ゃ", "'" }, { "ゅ", "(" }, { "ょ", ")" },
            { "っ", "z" },
            { "ー", "\\" }*/
        };

        public KanaJapanese(string[][] alpha) : base(alpha)
        {
        }

        public override DetectResult Detect(string progress, ConsoleKeyInfo input, int alphaIndex, int characterIndex)
        {
            var found = alpha[alphaIndex].Where(text => text.StartsWith(input.Key.ToString()));
            return DetectResult.OK;
        }
    }
}
