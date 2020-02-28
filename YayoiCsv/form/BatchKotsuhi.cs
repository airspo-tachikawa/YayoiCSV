using System;
using System.Linq;
using System.Windows.Forms;
using YayoiCsv.control;

namespace YayoiCsv
{
    /// <summary>
    /// 交通費、平日出力バッチ
    /// </summary>
    public partial class BatchKotsuhi : FormEx
    {
        enum ClickType
        {
            Shiwake,
            Csv,
            YayoiCsv,
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BatchKotsuhi()
        {
            InitializeComponent();
            SetCombo();
        }

        /// <summary>
        /// 補助科目から旅費交通費の補助科目を設定
        /// </summary>
        private void SetCombo()
        {
            cmbHojo.Items.Clear();
            cmbHojo.Items.AddRange(Static.HKmkList.Where(x => x.KmkName == "旅費交通費").Select(x => x.HKmkName).ToArray());
        }

        /// <summary>
        /// CSV出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCSV_Click(object sender, EventArgs e)
        {
            OutputCSV(ClickType.Csv);
        }

        /// <summary>
        /// CSV出力する
        /// </summary>
        /// <param name="isYayoi">弥生か？</param>
        private void OutputCSV(ClickType clickType)
        {
            if (IsOutput() == false) return;

            var date = new DateTime(Static.Nendo, 1, 1);
            var sb = new System.Text.StringBuilder();

            if (rdoHoliday.Checked)
            {
                while (Static.Nendo == date.Year)
                {
                    // 土曜日、日曜日、祝日を出力
                    int week = (int)date.DayOfWeek;
                    if (!Static.HolidayList.Any(x => x.Date == date) && !(week == 0 || week == 6))
                    {
                        date = date.AddDays(1);
                        continue;
                    }

                    if (clickType == ClickType.YayoiCsv)
                    {
                        // 弥生で取込めるフォーマット
                        sb.AppendLine(CreateYayoiCSV(date));
                    }
                    else if (clickType == ClickType.Csv)
                    {
                        // 日付,科目,補助科目,金額,摘要
                        sb.AppendLine(CreateCSV(date));
                    }
                    else
                    {
                        // 経費を足す
                        AddShiwake(date);
                    }

                    date = date.AddDays(1);
                }

            }
            else if (rdoYobi.Checked)
            {
                bool isChecked = false;
                foreach (Control ctl in grpYobi.Controls)
                {
                    if (ctl is CheckBox)
                    {
                        if ((ctl as CheckBox).Checked)
                        {
                            isChecked = true;
                            break;
                        }
                    }
                }

                if (!isChecked)
                {
                    MessageBox.Show("曜日が１つも指定されていません。曜日を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (Static.Nendo == date.Year)
                {

                    if ((chkYobiNichi.Checked && date.DayOfWeek == DayOfWeek.Sunday) ||
                        (chkYobiGetsu.Checked && date.DayOfWeek == DayOfWeek.Monday) ||
                        (chkYobiKa.Checked && date.DayOfWeek == DayOfWeek.Tuesday) ||
                        (chkYobiSui.Checked && date.DayOfWeek == DayOfWeek.Wednesday) ||
                        (chkYobiMoku.Checked && date.DayOfWeek == DayOfWeek.Thursday) ||
                        (chkYobiKin.Checked && date.DayOfWeek == DayOfWeek.Friday) ||
                        ((chkYobiDo.Checked && date.DayOfWeek == DayOfWeek.Saturday)))
                    {
                        if (clickType == ClickType.YayoiCsv)
                        {
                            // 弥生で取込めるフォーマット
                            sb.AppendLine(CreateYayoiCSV(date));
                        }
                        else if (clickType == ClickType.Csv)
                        {
                            // 日付,科目,補助科目,金額,摘要
                            sb.AppendLine(CreateCSV(date));
                        }
                        else
                        {
                            // 経費を足す
                            AddShiwake(date);
                        }
                    }

                    date = date.AddDays(1);
                }
            }
            else if (rdoTsuki.Checked)
            {

                bool isChecked = false;
                foreach (Control ctl in grpTsuki.Controls)
                {
                    if (ctl is CheckBox)
                    {
                        if ((ctl as CheckBox).Checked)
                        {
                            isChecked = true;
                            break;
                        }
                    }
                }

                if (!isChecked)
                {
                    MessageBox.Show("月が１つも指定されていません。月を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (Static.Nendo == date.Year)
                {

                    // 土曜日、日曜日、祝日は読み飛ばし
                    if (Static.HolidayList.Any(x => x.Date == date))
                    {
                        date = date.AddDays(1);
                        continue;
                    }

                    // 土日も外す
                    int week = (int)date.DayOfWeek;
                    if (week == 0 || week == 6)
                    {
                        date = date.AddDays(1);
                        continue;
                    }

                    if ((chkTsuki01.Checked && date.Month == 1) ||
                        (chkTsuki02.Checked && date.Month == 2) ||
                        (chkTsuki03.Checked && date.Month == 3) ||
                        (chkTsuki04.Checked && date.Month == 4) ||
                        (chkTsuki05.Checked && date.Month == 5) ||
                        (chkTsuki06.Checked && date.Month == 6) ||
                        (chkTsuki07.Checked && date.Month == 7) ||
                        (chkTsuki08.Checked && date.Month == 8) ||
                        (chkTsuki09.Checked && date.Month == 9) ||
                        (chkTsuki10.Checked && date.Month == 10) ||
                        (chkTsuki11.Checked && date.Month == 11) ||
                        (chkTsuki12.Checked && date.Month == 12) )
                    {
                        if (clickType == ClickType.YayoiCsv)
                        {
                            // 弥生で取込めるフォーマット
                            sb.AppendLine(CreateYayoiCSV(date));
                        }
                        else if (clickType == ClickType.Csv)
                        {
                            // 日付,科目,補助科目,金額,摘要
                            sb.AppendLine(CreateCSV(date));
                        }
                        else
                        {
                            // 経費を足す
                            AddShiwake(date);
                        }
                    }

                    date = date.AddDays(1);
                }

            }
            else
            {
                while (Static.Nendo == date.Year)
                {
                    if (rdoNormal.Checked)
                    {
                        // 休日は除外
                        if (Static.HolidayList.Any(x => x.Date == date))
                        {
                            date = date.AddDays(1);
                            continue;
                        }

                        // 土日も外す
                        int week = (int)date.DayOfWeek;
                        if (week == 0 || week == 6)
                        {
                            date = date.AddDays(1);
                            continue;
                        }
                    }

                    if (clickType == ClickType.YayoiCsv)
                    {
                        // 弥生で取込めるフォーマット
                        sb.AppendLine(CreateYayoiCSV(date));
                    }
                    else if (clickType == ClickType.Csv)
                    {
                        // 日付,科目,補助科目,金額,摘要
                        sb.AppendLine(CreateCSV(date));
                    }
                    else
                    {
                        // 経費を足す
                        AddShiwake(date);
                    }

                    date = date.AddDays(1);

                }
            }

            if (clickType != ClickType.Shiwake)
            {
                if (IsSaveFile(sb.ToString(), clickType == ClickType.YayoiCsv) == true)
                {
                    MessageBox.Show("CSV出力しました。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("経費に追加しました。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Static.SaveShiwakeXML();
            }
        }

        /// <summary>
        /// 出力できるか調べる
        /// </summary>
        /// <returns></returns>
        private bool IsOutput()
        {
            if (txtKin.Text == "")
            {
                MessageBox.Show("金額は必須です。\n金額を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKin.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 対象文字列を保存する
        /// </summary>
        /// <param name="target"></param>
        /// <param name="isYayoi">弥生の場合 true</param>
        private bool IsSaveFile(string target, bool isYayoi = false)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                // 摘要もファイル名に含める
                string tekiyo = txtTekiyo.Text.Trim() != "" ? "(" + txtTekiyo.Text.Trim() + ")" : "";

                // 初期表示するディレクトリを設定する
                saveDialog.InitialDirectory = @"C:\";
                saveDialog.FileName = Static.Nendo.ToString() + "年度_旅費交通費" + tekiyo + (isYayoi ? "(弥生)" : "");
                saveDialog.Filter = "テキスト ファイル|*.csv;";

                var result = saveDialog.ShowDialog(Static.ParentForm);
                if (result == DialogResult.OK)
                {
                    using (var writeFileStream = new System.IO.StreamWriter(saveDialog.FileName, false, System.Text.Encoding.GetEncoding("SJIS")))
                    {
                        writeFileStream.Write(target.ToString());
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// CSVファイルを１行作成する
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string CreateCSV(DateTime date)
        {
            return string.Concat(date.ToString("yyyy/MM/dd").ToDoubleQuote(), ",",
                        "旅費交通費".ToDoubleQuote(), ",",
                        cmbHojo.Text.Trim().ToDoubleQuote(), ",",
                        txtKin.Text.Trim().ToDoubleQuote(), ",",
                        txtTekiyo.Text.Trim().ToDoubleQuote());
        }

        /// <summary>
        /// CSVファイルを１行作成する
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string CreateYayoiCSV(DateTime date)
        {
            return Static.CreateYayoiCSVRow(date, "旅費交通費",
                cmbHojo.Text.Trim(),
                txtKin.Text.Trim(),
                txtTekiyo.Text);
        }

        /// <summary>
        /// 経費を足す
        /// </summary>
        /// <param name="date">年月日</param>
        private void AddShiwake(DateTime date)
        {
            var row = Static.ShiwakeDs.Shiwake.NewShiwakeRow();
            row.KmkKbn = KmkKbn.経費.ToString();
            row.No = Static.GetShiwakeNo();
            row.CustomDate = date.ToString("MMdd");
            row.KrKmkName = "旅費交通費";
            row.KrHKmkName = cmbHojo.Text.Trim();
            row.Tekiyo = txtTekiyo.Text.Trim();
            row.Kingaku = decimal.Parse(txtKin.Text.Trim());
            row.KsKmkName = "現金";
            row.KsHKmkName = "";
            row.Week = date.ToString("ddd");
            Static.ShiwakeDs.Shiwake.AddShiwakeRow(row);
        }

        /// <summary>
        /// 弥生で取り込めるCSVを出力する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYayoiCSV_Click(object sender, EventArgs e)
        {
            OutputCSV(ClickType.YayoiCsv);
        }

        private void btnShiwakeAdd_Click(object sender, EventArgs e)
        {
            OutputCSV(ClickType.Shiwake);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Static.CloseChildForm(this.GetType());
        }
    }
}
