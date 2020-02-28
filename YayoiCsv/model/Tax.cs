using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace YayoiCsv
{
    /// <summary>
    /// 消費税
    /// </summary>
    public class Tax
    {
        /// <summary>
        /// 開始日
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 終了日
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        public int TaxRate { get; set; }
    }
}
