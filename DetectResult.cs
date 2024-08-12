using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingGameWpf
{
    public enum DetectResult
    {
        /// <summary>
        /// 文章入力完了。
        /// </summary>
        AllClear,
        /// <summary>
        /// 入力途中。
        /// </summary>
        Clear,
        /// <summary>
        /// 入力完了。
        /// </summary>
        OK,
        /// <summary>
        /// 日本語として該当しない。
        /// </summary>
        NG
    }
}
