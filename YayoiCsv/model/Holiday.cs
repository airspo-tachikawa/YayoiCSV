using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YayoiCsv
{
    public class Holiday
    {
        public const string HolidayXmlFolder = @"xml\holiday";

        /// <summary>
        /// 休日名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 日付
        /// </summary>
        public DateTime Date { get; set; }
    }
}
