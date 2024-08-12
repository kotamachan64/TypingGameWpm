using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    internal abstract class Launguage : ILaunguage
    {
        internal readonly string[][] alpha;
        internal readonly int alphaLastIndex = 0;

        public Launguage(string[][] alpha)
        {
            this.alpha = alpha;
            this.alphaLastIndex = alpha.Length - 1;
        }

        public abstract DetectResult Detect(string progress, ConsoleKeyInfo input, int alphaIndex, int characterIndex);
    }
}
