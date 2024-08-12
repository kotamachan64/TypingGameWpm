using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    internal interface ILaunguage
    {
        DetectResult Detect(string progress, ConsoleKeyInfo input, int alphaIndex, int characterIndex);
    }
}
