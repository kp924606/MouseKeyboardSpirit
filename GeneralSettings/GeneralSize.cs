using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseKeyboardSpirit.GeneralSettings
{
    /// <summary>
    /// 通用尺寸
    /// </summary>
    public static class GeneralSize
    {
        /// <summary>
        /// 畫面預設高度
        /// </summary>
        public const double WindowDefaultHeight = WindowControlRowHeight + WindowMessageRowHeight + 30;
        //public const double WindowDefaultHeight = 100;

        /// <summary>
        /// 畫面展開高度
        /// </summary>
        public const double WindowExpandHeight = WindowControlRowHeight + WindowMessageRowHeight + WindowTabViewRowHeight + WindowSelfRowHeight + 50;
        //public const double WindowExpandHeight = 450;

        /// <summary>
        /// 畫面寬度
        /// </summary>
        public const double WindowWidth = 400;

        public const double WindowControlRowHeight = 50;
        public const double WindowMessageRowHeight = 20;
        public const double WindowTabViewRowHeight = 270;
        public const double WindowSelfRowHeight = 50;

        public const double ButtonPullPushSize = 40;

    }
}
