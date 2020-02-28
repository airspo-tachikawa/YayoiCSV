using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace YayoiCsv
{
    /// <summary>
    /// 弥生会計に連携CSVを出力するプロジェクト
    /// </summary>
    class Program
    {
        [STAThread]
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        static void Main()
        {
            try
            {
                Static.ParentForm = new MDIParent();

                Static.SystemInit();

                Application.Run(Static.ParentForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat(ex.Message, "\n", ex.StackTrace));
            }
        }


    }
}
