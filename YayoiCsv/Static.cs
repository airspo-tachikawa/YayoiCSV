using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.Data;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;
using System.Xml;
using ClosedXML.Excel;

namespace YayoiCsv
{
    /// <summary>
    /// 静的メンバ
    /// </summary>
    public static class Static
    {
        #region プロパティ

        /// <summary>
        /// 年度
        /// </summary>
        public static int Nendo
        {
            get
            {
                return _nendo;
            }
            set
            {
                if (_nendo == 0)
                {
                    Static.InitShowChildForm();
                }

                _nendo = value;

                ParentForm.Title = "弥生会計 経費入力 サポート (" + value.ToString() + "年度)";
                SetNendoHoliday(Static.Nendo);
                ReadZandakaXML();
                ReadShiwakeXML();
                ParentForm.MenuEnabled(true);


            }
        }
        private static int _nendo;
        /// <summary>
        /// 休日
        /// </summary>
        public static List<Holiday> HolidayList { get; set; }

        /// <summary>
        /// 税率リスト
        /// </summary>
        public static List<Tax> TaxList { get; set; }

        /// <summary>
        /// 科目リスト
        /// </summary>
        public static List<Kamoku> KmkList { get; set; }

        /// <summary>
        /// 補助科目リスト
        /// </summary>
        public static List<HojoKamoku> HKmkList { get; set; }

        /// <summary>
        /// 親画面
        /// </summary>
        public static MDIParent ParentForm { get; set; }

        /// <summary>
        /// 画面リスト
        /// </summary>
        private static List<Form> ChildFormList { get; set; }

        /// <summary>
        /// 経費入力用のDataSet
        /// </summary>
        public static ShiwakeDs ShiwakeDs { get; set; }

        #endregion

        #region 仕訳データ関連

        public static void ShiwakeChanged()
        {
            decimal uriage = 0;
            decimal keihi = 0;

            if (ShiwakeDs.Shiwake.Count == 0)
            {
                return;
            }

            // ------------------------------------------------------------------
            // 経費合計を計算
            // ------------------------------------------------------------------
            ShiwakeDs.KeihiSum.Clear();
            var sumKeihiGroup = ShiwakeDs.Shiwake.Where(x => x.KmkKbn == KmkKbn.経費.ToString()).
                GroupBy(x => x.KrKmkName).Select(g => new { KrKmkName = g.Key, Kingaku = g.Sum(x => x.Kingaku) });

            foreach (var kmkSum in sumKeihiGroup)
            {
                var row = ShiwakeDs.KeihiSum.NewKeihiSumRow();
                row.KrKmkName = kmkSum.KrKmkName;
                row.Kingaku = kmkSum.Kingaku;
                ShiwakeDs.KeihiSum.AddKeihiSumRow(row);
            }

            // ------------------------------------------------------------------
            // 仕訳合計（現金、普通預金、定期預金、売掛金、事業貸主）
            // ------------------------------------------------------------------
            ShiwakeDs.ShisanSum.Clear();
            var sumGKr = ShiwakeDs.Shiwake.Where(x => x.KmkKbn == KmkKbn.資産.ToString()).
                GroupBy(x => new { KmkName = x.KrKmkName, HKmkName = x.KrHKmkName }).
                Select(g => new { KmkName = g.Key.KmkName, HKmkName = g.Key.HKmkName, Kingaku = g.Sum(x => x.Kingaku) });

            var sumGKs = ShiwakeDs.Shiwake.Where(x => x.KmkKbn == KmkKbn.資産.ToString()).
                GroupBy(x => new { KmkName = x.KsKmkName, HKmkName = x.KsHKmkName }).
                Select(g => new { KmkName = g.Key.KmkName, HKmkName = g.Key.HKmkName, Kingaku = g.Sum(x => x.Kingaku) });

            foreach (var item in KmkList.Where(x => x.KmkKbn == KmkKbn.資産.ToString()).
                Join(sumGKr, x => new { x.KmkName }, y => new { y.KmkName }, (x, y) => new { y.KmkName, y.HKmkName, y.Kingaku }))
            {
                var row = ShiwakeDs.ShisanSum.NewShisanSumRow();

                decimal ks = sumGKs.Where(x => x.KmkName == item.KmkName && x.HKmkName == item.HKmkName).Select(x => x.Kingaku).FirstOrDefault();
                decimal kingaku = item.Kingaku - ks;

                row.KmkName = item.KmkName;
                row.HKmkName = item.HKmkName;

                if (item.KmkName.IndexOf("売上高") >= 0)
                {
                    row.Kingaku = -1 * kingaku;
                    uriage = row.Kingaku;
                }
                else
                {
                    row.Kingaku = kingaku;
                }

                // 売掛の前年度引継ぎ
                // ToDo : 今のところ補助科目の考慮が無いので、処理を追加する必要がある
                if (ShiwakeDs.Zandaka.Count != 0 && ShiwakeDs.Zandaka[0].Urikake.Trim() != string.Empty)
                {
                    if (row.KmkName == "売掛金")
                    {
                        int o = 0;
                        int.TryParse(ShiwakeDs.Zandaka[0].Urikake, out o);
                        row.Kingaku = row.Kingaku += o;
                    }
                }

                ShiwakeDs.ShisanSum.AddShisanSumRow(row);
            }

            foreach (var item in sumGKs)
            {
                // 貸方にしかない場合は、こちらから表示する
                var sumGr = sumGKr.Where(x => x.KmkName == item.KmkName && x.HKmkName == item.HKmkName).FirstOrDefault();
                if (sumGr == null)
                {
                    var row = ShiwakeDs.ShisanSum.NewShisanSumRow();

                    row.KmkName = item.KmkName;
                    row.HKmkName = item.HKmkName;

                    if (item.KmkName.IndexOf("売上高") >= 0)
                    {
                        row.Kingaku = item.Kingaku;
                        uriage = row.Kingaku;
                    }
                    else
                    {
                        row.Kingaku = -1 * item.Kingaku;
                    }
                    ShiwakeDs.ShisanSum.AddShisanSumRow(row);
                }
            }

            var rowKeihi = ShiwakeDs.ShisanSum.NewShisanSumRow();
            rowKeihi.KmkName = KmkKbn.経費.ToString();
            rowKeihi.Kingaku = ShiwakeDs.KeihiSum.Sum(x => x.Kingaku);
            keihi = rowKeihi.Kingaku;
            ShiwakeDs.ShisanSum.AddShisanSumRow(rowKeihi);

            var rowUriageKeihi = ShiwakeDs.ShisanSum.NewShisanSumRow();
            rowUriageKeihi.KmkName = "売上高 - 経費";
            rowUriageKeihi.Kingaku = uriage - keihi;

            ShiwakeDs.ShisanSum.AddShisanSumRow(rowUriageKeihi);

            // ------------------------------------------------------------------
            // 現金出納帳
            // ------------------------------------------------------------------
            SetGenkinSuitocho();

            // ------------------------------------------------------------------
            // 預金出納帳
            // ------------------------------------------------------------------
            SetYokinSuitocho();

        }

        private static void SetGenkinSuitocho()
        {
            ShiwakeDs.GenkinSuitocho.Clear();
            decimal zanKingaku = 0;
            if (ShiwakeDs.Zandaka.Count != 0 && ShiwakeDs.Zandaka[0].GenKin.Trim() != string.Empty)
            {
                var row = ShiwakeDs.GenkinSuitocho.NewGenkinSuitochoRow();
                row.KmkName = "前年繰越";
                row.KrKingaku = 0;
                row.KsKingaku = 0;
                row.ZanKingaku = decimal.Parse(ShiwakeDs.Zandaka[0].GenKin);
                ShiwakeDs.GenkinSuitocho.AddGenkinSuitochoRow(row);
                zanKingaku = row.ZanKingaku;
            }
            foreach (var shiwake in ShiwakeDs.Shiwake.Where(x => x.KrKmkName == "現金" || x.KsKmkName == "現金").OrderBy(x => x.CustomDate).ThenByDescending(x => x.KmkKbn))
            {
                var row = ShiwakeDs.GenkinSuitocho.NewGenkinSuitochoRow();
                row.KmkName = shiwake.KrKmkName;

                row.CustomDate = shiwake.CustomDate;
                row.Week = shiwake.Week;

                if (shiwake.KrKmkName == "現金")
                {
                    zanKingaku += shiwake.Kingaku;
                    row.KrKingaku = shiwake.Kingaku;
                    row.KsKingaku = 0;
                }
                else if (shiwake.KsKmkName == "現金")
                {
                    zanKingaku -= shiwake.Kingaku;
                    row.KrKingaku = 0;
                    row.KsKingaku = shiwake.Kingaku;
                }

                row.ZanKingaku = zanKingaku;

                ShiwakeDs.GenkinSuitocho.AddGenkinSuitochoRow(row);
            }
        }

        private static void SetYokinSuitocho()
        {
            ShiwakeDs.YokinSuitocho.Clear();
            decimal zanKingaku = 0;
            if (ShiwakeDs.Zandaka.Count != 0 && ShiwakeDs.Zandaka[0].YoKin.Trim() != string.Empty)
            {
                var row = ShiwakeDs.YokinSuitocho.NewYokinSuitochoRow();
                row.KrKmkName = "前年繰越";
                row.KrKingaku = 0;
                row.KsKingaku = 0;
                row.ZanKingaku = decimal.Parse(ShiwakeDs.Zandaka[0].YoKin);
                ShiwakeDs.YokinSuitocho.AddYokinSuitochoRow(row);
                zanKingaku = row.ZanKingaku;
            }
            foreach (var shiwake in ShiwakeDs.Shiwake.Where(x => x.KrKmkName.IndexOf("預金") >= 0 || x.KsKmkName.IndexOf("預金") >= 0).OrderBy(x => x.KmkKbn).ThenBy(x => x.CustomDate))
            {
                var row = ShiwakeDs.YokinSuitocho.NewYokinSuitochoRow();
                row.KrKmkName = shiwake.KrKmkName;
                row.KrHKmkName = shiwake.KrHKmkName;

                row.KsKmkName = shiwake.KsKmkName;
                row.KsHKmkName = shiwake.KsHKmkName;

                row.CustomDate = shiwake.CustomDate;
                row.Week = shiwake.Week;

                if (shiwake.KrKmkName.IndexOf("預金") >= 0)
                {
                    zanKingaku += shiwake.Kingaku;
                    row.KrKingaku = shiwake.Kingaku;
                    row.KsKingaku = 0;
                }
                else if (shiwake.KsKmkName.IndexOf("預金") >= 0)
                {
                    zanKingaku -= shiwake.Kingaku;
                    row.KrKingaku = 0;
                    row.KsKingaku = shiwake.Kingaku;
                }

                row.ZanKingaku = zanKingaku;

                ShiwakeDs.YokinSuitocho.AddYokinSuitochoRow(row);
            }
        }

        /// <summary>
        /// 仕訳データの番号取得
        /// </summary>
        /// <returns></returns>
        public static int GetShiwakeNo()
        {
            return Static.ShiwakeDs.Shiwake.Count == 0 ? 1 : Static.ShiwakeDs.Shiwake.Max(x => x.No) + 1;
        }

        #endregion

        #region 初期処理

        /// <summary>
        /// 初期処理
        /// </summary>
        public static void SystemInit()
        {
            SetTax();
            SetKmk();
            SetHKmk();
            ShiwakeDs = new ShiwakeDs();

            ReadFormPosition();

            var positionRow = Static.ShiwakeDs.FormPosition.Where(x => x.FormName == typeof(MDIParent).FullName).FirstOrDefault();
            if (positionRow != null)
            {
                if ((FormWindowState)positionRow.WindowState == FormWindowState.Maximized)
                {
                    Static.ParentForm.WindowState = FormWindowState.Maximized;
                }
                Static.ParentForm.Height = positionRow.Height;
                Static.ParentForm.Width = positionRow.Width;
            }

            ReadNendo();

        }

        #endregion

        #region 画面管理

        /// <summary>
        /// 子画面を開く
        /// </summary>
        /// <param name="type">開く画面</param>
        public static void ShowChildForm(Type type, int? height = null, int? width = null, int? top = null, int? left = null)
        {
            if (ChildFormList == null)
            {
                ChildFormList = new List<Form>();
            }

            if (!ChildFormList.Any(x => x.GetType() == type))
            {
                var form = (Form)Activator.CreateInstance(type);
                ChildFormList.Add(form);
                form.MdiParent = ParentForm;

                if (height != null) form.Height = (int)height;
                if (width != null) form.Width = (int)width;

                if (top != null)
                {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Top = (int)top;
                    form.Left = (int)left;
                }
                form.Show();
            }
            else
            {
                var form = ChildFormList.Where(x => x.GetType() == type).First();
                form.Show();
                form.Activate();
            }
        }

        /// <summary>
        /// 子画面が開いているか確認
        /// </summary>
        /// <param name="type">調べる画面</param>
        /// <returns>true : false </returns>
        public static bool IsOpenChildForm(Type type)
        {
            if (ChildFormList.Any(x => x.GetType() == type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 子画面を非表示にする
        /// </summary>
        /// <param name="type">閉じる画面</param>
        public static void CloseChildForm(Type type)
        {
            var form = ChildFormList.Where(x => x.GetType() == type).FirstOrDefault();
            if (form != null)
            {
                form.Close();
                ChildFormList.Remove(form);
            }
        }

        /// <summary>
        /// 初期子画面の配置
        /// </summary>
        public static void InitShowChildForm()
        {
            foreach (var row in Static.ShiwakeDs.FormPosition)
            {
                if (row.FormName != ParentForm.GetType().FullName)
                {
                    var t = Type.GetType(row.FormName);
                    ShowChildForm(t, row.Height, row.Width, row.Top, row.Left);
                }
            }
        }

        /// <summary>
        /// 画面の位置情報を保持する
        /// </summary>
        public static void SaveFormPosition()
        {
            Static.ShiwakeDs.FormPosition.Clear();
            SetFormPositionRow(ParentForm);

            if (ChildFormList != null)
            {
                foreach (var form in ChildFormList)
                {
                    SetFormPositionRow(form);
                }
            }

            Static.ShiwakeDs.FormPosition.WriteXml(@"xml\form_position.xml");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        static void SetFormPositionRow(Form form)
        {
            var row = Static.ShiwakeDs.FormPosition.NewFormPositionRow();
            row.FormName = form.GetType().FullName;
            row.WindowState = (int)form.WindowState;
            row.Height = form.Height;
            row.Width = form.Width;
            row.Top = form.Top;
            row.Left = form.Left;
            Static.ShiwakeDs.FormPosition.AddFormPositionRow(row);
        }

        /// <summary>
        /// 前回のフォームの場所を読み込む
        /// </summary>
        public static void ReadFormPosition()
        {
            if (System.IO.File.Exists(@"xml\form_position.xml"))
            {
                Static.ShiwakeDs.FormPosition.ReadXml(@"xml\form_position.xml");
            }
        }

        public static void WriteNendo()
        {
            var xDoc = new XmlDocument();
            xDoc.AppendChild(xDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            var xEle = xDoc.CreateElement("last_nendo");
            xEle.InnerText = Nendo.ToString();
            xDoc.AppendChild(xEle);
            xDoc.Save(@"xml\nendo.xml");
        }

        /// <summary>
        /// 年度読込
        /// </summary>
        public static void ReadNendo()
        {
            if (System.IO.File.Exists(@"xml\nendo.xml"))
            {
                var xDoc = XDocument.Load(@"xml\nendo.xml");
                Nendo = (int)xDoc.Element("last_nendo");
            }
        }

        #endregion

        #region 拡張メソッド

        /// <summary>
        /// DoubleQuoteをつける
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string ToDoubleQuote(this string target)
        {
            return "\"" + target + "\"";
        }

        #endregion

        #region 勘定科目／補助科目

        /// <summary>
        /// 科目リストを作成
        /// </summary>
        public static void SetKmk()
        {
            Static.KmkList = new List<Kamoku>();

            var xDoc = XDocument.Load(@"xml\kmk.xml");
            var xItems = xDoc.Element("kmks").Elements("kmk");

            foreach (var item in xItems.Select(x => new Kamoku()
            {
                KmkKbn = (string)x.Element("kbn"),
                KmkName = (string)x.Element("name")
            }))
            {
                Static.KmkList.Add(item);
            }
        }

        /// <summary>
        /// 補助科目リストを作成
        /// </summary>
        public static void SetHKmk()
        {
            Static.HKmkList = new List<HojoKamoku>();

            var xDoc = XDocument.Load(@"xml\hkmk.xml");
            var xItems = xDoc.Element("hkmks").Elements("hkmk");

            foreach (var item in xItems.Select(x => new HojoKamoku()
            {
                KmkName = (string)x.Element("kmkname"),
                HKmkName = (string)x.Element("hkmkname")
            }))
            {
                Static.HKmkList.Add(item);
            }
        }

        #endregion

        #region 消費税

        /// <summary>
        /// 消費税リストを作成
        /// </summary>
        public static void SetTax()
        {
            Static.TaxList = new List<Tax>();

            var xDoc = XDocument.Load(@"xml\tax.xml");
            var xItems = xDoc.Element("items").Elements("item");

            foreach (var item in xItems.Select(x => new Tax()
            {
                TaxRate = (int)x.Element("tax_rate"),
                StartDate = (DateTime)x.Element("start_date"),
                EndDate = (DateTime)x.Element("end_date")

            }))
            {
                Static.TaxList.Add(item);
            }
        }

        #endregion

        #region 祝日

        /// <summary>
        /// 指定した年度で、HolidayListを作成する
        /// </summary>
        /// <param name="nendo">年度</param>
        public static void SetNendoHoliday(int nendo)
        {
            try
            {
                Static.HolidayList = new List<Holiday>();
                CreateXmlHolidayYear();
            }
            catch (Exception)
            {
                MessageBox.Show("インターネットの回線が切断されているため、\r\n最新の祝日情報が取得できません。\r\n前回の祝日情報で表示されます。",
                    "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var xDoc = XDocument.Load(System.IO.Path.Combine(Holiday.HolidayXmlFolder, nendo.ToString() + ".xml"));
            var xHolidays = xDoc.Element("Holidays").Elements("Holiday");

            foreach (var holiday in xHolidays.Select(x => new Holiday() { Date = (DateTime)x.Element("Day"), Name = (string)x.Element("Name") }))
            {
                Static.HolidayList.Add(holiday);
            }




        }

        /// <summary>
        /// 祝日ファイルのURL取得
        /// </summary>
        /// <param name="key">取得情報キー</param>
        /// <returns>URL</returns>
        private static string getUrlOfHoliday(string key)
        {
            var xDoc = XDocument.Load(@"xml\url.xml");
            var xItems = xDoc.Element("items").Elements("item");

            return xItems.Where(x => (string)x.Element("key") == key).Select(x => (string)x.Element("value")).First();
        }

        /// <summary>
        /// Xmlファイル作成（年別休日）
        /// </summary>
        static void CreateXmlHolidayYear()
        {
            // 内閣府のHPからCSVを取得して、休日ファイルを作成
            string address = getUrlOfHoliday("祝日");

            var holidays = new List<Holiday>();

            var request = System.Net.WebRequest.Create(address);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("Shift_JIS")))
                    {
                        do
                        {
                            DateTime o;
                            var items = reader.ReadLine().Split(',');
                            if (DateTime.TryParse(items[0], out o))
                            {
                                var holiday = new Holiday()
                                {
                                    Name = items[1],
                                    Date = o
                                };
                                holidays.Add(holiday);
                            }

                        } while (!reader.EndOfStream);
                    }
                }
            }

            holidays.Select(x => x.Date.Year).Distinct().ForEach(nendo =>
            {
                // フォルダの作成
                if (!System.IO.Directory.Exists(Holiday.HolidayXmlFolder))
                {
                    System.IO.Directory.CreateDirectory(Holiday.HolidayXmlFolder);
                }

                string filePath = System.IO.Path.Combine(Holiday.HolidayXmlFolder, string.Concat(nendo.ToString(), ".xml"));

                // ファイルが存在するなら、処理しない
                if (System.IO.File.Exists(filePath)) return;

                // 既存のフォーマットに合わせるために、XMLファイルの構造を変更しない
                var xmlDocument = new System.Xml.XmlDocument();
                var xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                var eleHolidays = xmlDocument.CreateElement("Holidays");

                xmlDocument.AppendChild(xmlDeclaration);
                xmlDocument.AppendChild(eleHolidays);

                holidays.Where(x => x.Date.Year == nendo).ForEach(y =>
                {
                    var eleHoliday = xmlDocument.CreateElement("Holiday");
                    var eleDay = xmlDocument.CreateElement("Day");
                    var eleName = xmlDocument.CreateElement("Name");

                    eleDay.InnerText = y.Date.ToString();
                    eleName.InnerText = y.Name;

                    eleHoliday.AppendChild(eleDay);
                    eleHoliday.AppendChild(eleName);
                    eleHolidays.AppendChild(eleHoliday);
                });

                xmlDocument.Save(filePath);
            });
        }

        #endregion

        #region 曜日

        /// <summary>
        /// 曜日を取得
        /// </summary>
        /// <param name="day">月日（4桁の数字）</param>
        /// <returns>曜日（１桁）</returns>
        public static string GetWeekName(string monthDay)
        {
            return new DateTime(Nendo, int.Parse(monthDay.Substring(0, 2)), int.Parse(monthDay.Substring(2, 2))).ToString("ddd");
        }

        #endregion

        #region 弥生会計で取り込める形式でCSV出力

        /// <summary>
        /// 仕訳データ
        /// </summary>
        public static string CreateYayoiCSVShiwake(bool isNew)
        {
            var sb = new StringBuilder();

            foreach (ShiwakeDs.ShiwakeRow row in Static.ShiwakeDs.Shiwake)
            {
                var date = new DateTime(Static.Nendo, int.Parse(row.CustomDate.Substring(0, 2)), int.Parse(row.CustomDate.Substring(2, 2)));

                sb.AppendLine(CreateYayoiCSVRow(date, row.KrKmkName, row.KrHKmkName, row.Kingaku.ToString(), row.Tekiyo, row.KsKmkName, row.KsHKmkName, isNew));
            }

            return sb.ToString();

        }

        /// <summary>
        /// 弥生のCSV形式で成形したデータを作成する
        /// </summary>
        /// <param name="date">日付</param>
        /// <param name="krKmkNm">借方科目名</param>
        /// <param name="krHkmkNm">借方補助科目名</param>
        /// <param name="krKn">借方金額</param>
        /// <param name="tekiyo">摘要</param>
        /// <param name="ksKmkNm">貸方科目コード</param>
        /// <param name="isNew">新バージョンフラグ</param>
        /// <returns></returns>
        public static string CreateYayoiCSVRow(DateTime date, string krKmkNm, string krHkmkNm, string krKn, string tekiyo = "", string ksKmkNm = "現金", string ksHkmkNm = "", bool isNew = true)
        {
            // 消費税算出
            var tax = Static.TaxList.Where(x => x.StartDate <= date && x.EndDate >= date).FirstOrDefault();
            string taxString = "";
            if (tax == null)
            {
                taxString = "課対仕入込0%";
            }
            else
            {
                taxString = "課対仕入込" + tax.TaxRate.ToString() + "%";
            }

            // ==============================
            // 弥生会計のフォーマット
            // ==============================
            //  1 - 必須 - 識別フラグ
            //  2 - 任意 - 伝票No
            //  3 - 任意 - 決算
            //  4 - 必須 - 取引日付
            //  5 - 必須 - 借方勘定科目
            //  6 - 任意 - 借方補助科目
            //  7 - 任意 - 借方部門
            //  8 - 必須 - 借方税区分
            //  9 - 必須 - 借方金額
            // 10 - 任意 - 借方税金額
            // 11 - 必須 - 貸方勘定科目
            // 12 - 任意 - 貸方補助科目
            // 13 - 任意 - 貸方部門
            // 14 - 必須 - 貸方税区分
            // 15 - 必須 - 貸方金額
            // 16 - 任意 - 貸方税金額
            // 17 - 任意 - 摘要
            // 18 - 任意 - 番号
            // 19 - 任意 - 期日
            // 20 - 必須 - タイプ
            // 21 - 任意 - 生成元
            // 22 - 任意 - 仕訳メモ
            // 23 - 任意 - 付箋1
            // 24 - 任意 - 付箋2
            // 25 - 必須 - 調整
            // 26 - 任意 - 借方取引先名
            // 27 - 任意 - 貸方取引先名
            // ※旧バージョンは25まで
            // ==============================
            if (isNew)
            {
                return string.Concat("2000".ToDoubleQuote(), ",",
                    "".ToDoubleQuote() + ",",
                    "".ToDoubleQuote() + ",",
                    date.ToString("yyyy/MM/dd").ToDoubleQuote(), ",",
                    krKmkNm.ToDoubleQuote(), ",",
                    krHkmkNm.ToDoubleQuote(), ",",
                    "".ToDoubleQuote() + ",",
                    taxString.ToDoubleQuote(), ",",
                    krKn.ToDoubleQuote(), ",",
                    "0".ToDoubleQuote(), ",",
                    ksKmkNm.ToDoubleQuote(), ",",
                    ksHkmkNm.ToDoubleQuote() + ",",
                    "".ToDoubleQuote() + ",",
                    "対象外".ToDoubleQuote(), ",",
                    krKn.ToDoubleQuote(), ",",
                    "0".ToDoubleQuote(), ",",
                    tekiyo.ToDoubleQuote(), ",",
                    "".ToDoubleQuote() + ",",
                    "".ToDoubleQuote() + ",",
                    "0".ToDoubleQuote(), ",",
                    "".ToDoubleQuote() + ",",
                    "".ToDoubleQuote() + ",",
                    "0".ToDoubleQuote(), ",",
                    "0".ToDoubleQuote(), ",",
                    "no".ToDoubleQuote(), ",",
                    "".ToDoubleQuote(), ",",
                    "".ToDoubleQuote()
                    );
            }
            else
            {
                return string.Concat("2000".ToDoubleQuote(), ",",
                   "".ToDoubleQuote() + ",",
                   "".ToDoubleQuote() + ",",
                   date.ToString("yyyy/MM/dd").ToDoubleQuote(), ",",
                   krKmkNm.ToDoubleQuote(), ",",
                   krHkmkNm.ToDoubleQuote(), ",",
                   "".ToDoubleQuote() + ",",
                   taxString.ToDoubleQuote(), ",",
                   krKn.ToDoubleQuote(), ",",
                   "0".ToDoubleQuote(), ",",
                   ksKmkNm.ToDoubleQuote(), ",",
                   ksHkmkNm.ToDoubleQuote() + ",",
                   "".ToDoubleQuote() + ",",
                   "対象外".ToDoubleQuote(), ",",
                   krKn.ToDoubleQuote(), ",",
                   "0".ToDoubleQuote(), ",",
                   tekiyo.ToDoubleQuote(), ",",
                   "".ToDoubleQuote() + ",",
                   "".ToDoubleQuote() + ",",
                   "0".ToDoubleQuote(), ",",
                   "".ToDoubleQuote() + ",",
                   "".ToDoubleQuote() + ",",
                   "0".ToDoubleQuote(), ",",
                   "0".ToDoubleQuote(), ",",
                   "no".ToDoubleQuote()
                   );
            }

        }

        #endregion

        #region 弥生会計のCSVデータを取得

        /// <summary>
        /// 仕訳データ取込
        /// </summary>
        /// <param name="path"></param>
        public static void AddShiwakeFromCSV(bool isAppend)
        {
            string path = "";
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV Files|*.csv";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {

                if (!isAppend)
                {
                    SaveShiwakeXML();
                    Static.ShiwakeDs.Shiwake.Clear();
                }

                new Exception();

                // ==============================
                // 弥生会計のフォーマット
                // ==============================
                //  1 - 必須 - 識別フラグ
                //  2 - 任意 - 伝票No
                //  3 - 任意 - 決算
                //  4 - 必須 - 取引日付      ○
                //  5 - 必須 - 借方勘定科目  ○
                //  6 - 任意 - 借方補助科目  ○
                //  7 - 任意 - 借方部門
                //  8 - 必須 - 借方税区分
                //  9 - 必須 - 借方金額      ○
                // 10 - 任意 - 借方税金額
                // 11 - 必須 - 貸方勘定科目  ○
                // 12 - 任意 - 貸方補助科目  ○
                // 13 - 任意 - 貸方部門
                // 14 - 必須 - 貸方税区分
                // 15 - 必須 - 貸方金額
                // 16 - 任意 - 貸方税金額
                // 17 - 任意 - 摘要          ○
                // 18 - 任意 - 番号
                // 19 - 任意 - 期日
                // 20 - 必須 - タイプ
                // 21 - 任意 - 生成元
                // 22 - 任意 - 仕訳メモ
                // 23 - 任意 - 付箋1
                // 24 - 任意 - 付箋2
                // 25 - 必須 - 調整
                // 26 - 任意 - 借方取引先名
                // 27 - 任意 - 貸方取引先名
                // ※旧バージョンは25まで
                // ==============================

                // 
                // Ole DBと同じになるように処理を組み立てる
                // // Ole は、インストールが必要だから廃止
                // 
                var parser = new TextFieldParser(path, Encoding.GetEncoding("Shift_JIS"));
                parser.SetDelimiters(",");

                var dt = new DataTable();

                for (int i = 1; i < 28; i++) dt.Columns.Add("F" + i.ToString(), typeof(string));

                while (!parser.EndOfData)
                {
                    var csvCells = parser.ReadFields();
                    var row = dt.NewRow();

                    if (csvCells.Length < 25)
                    {
                        MessageBox.Show("取込データの列数が弥生の仕訳データの必須項目数に満たないため、取り込めません。", "取込エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    for (int i = 0; i < csvCells.Length; i++)
                    {
                        row[i] = csvCells[i];
                    }
                    dt.Rows.Add(row);
                }

                //// CSVファイル読み込み(Ole.4.0 をインストールしないと動かないので、独自で読み込む)
                //string conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Path.GetDirectoryName(path) + ";Extended Properties=\"text;HDR=No;FMT=Delimited\"";
                //var con = new System.Data.OleDb.OleDbConnection(conString);
                //var da = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [" + System.IO.Path.GetFileName(path) + "]", con);


                //da.Fill(dt);

                //if (dt.Columns.Count != 25)
                //{
                //    MessageBox.Show("取込データの列数が弥生の仕訳データと異なるため、取り込めません。", "取込エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                dt.Columns.Add("Error", typeof(string));

                int rowNo = 1;

                foreach (DataRow row in dt.Rows)
                {
                    string errorMsg = "";
                    DateTime o = new DateTime();

                    // 取引日付
                    if (row["F4"].ToString() == "")
                    {
                        errorMsg += "取引日付が空白です;";
                    }
                    else
                    {
                        if (!DateTime.TryParse(row["F4"].ToString(), out o))
                        {
                            errorMsg += "取引日付が日付ではありません;";
                        }
                        if (o.Year != Static.Nendo)
                        {
                            errorMsg += "取引日付が年度と異なります;";
                        }
                    }

                    // 勘定科目
                    if (row["F5"].ToString() == "")
                    {
                        errorMsg += "借方勘定科目が空白です;";
                    }
                    else if (!Static.KmkList.Any(x => x.KmkName == row["F5"].ToString()))
                    {
                        errorMsg += "借方勘定科目がシステムで認識できない為、外取り込めません;";
                    }
                    decimal d = 0;
                    if (row["F9"].ToString() == "")
                    {
                        errorMsg += "借方金額が空白です;";
                    }
                    else
                    {
                        if (!decimal.TryParse(row["F9"].ToString(), out d))
                        {
                            errorMsg += "借方金額が数値ではありません;";
                        }
                    }
                    if (row["F11"].ToString() == "")
                    {
                        errorMsg += "貸方勘定科目が空白です;";
                    }
                    else if (!Static.KmkList.Any(x => x.KmkName == row["F11"].ToString()))
                    {
                        errorMsg += "貸方勘定科目がシステムで認識できない為、外取り込めません;";
                    }

                    if (errorMsg != "")
                    {
                        row["Error"] = rowNo.ToString() + "行目 : " + errorMsg;
                    }
                    else
                    {
                        var shiwake = Static.ShiwakeDs.Shiwake.NewShiwakeRow();
                        shiwake.No = GetShiwakeNo();
                        shiwake.KmkKbn = KmkList.Where(x => row["F5"].ToString() == x.KmkName).Select(x => x.KmkKbn).First();
                        shiwake.CustomDate = o.ToString("MMdd");
                        shiwake.Week = o.ToString("ddd");
                        shiwake.KrKmkName = row["F5"].ToString();
                        shiwake.KrHKmkName = row["F6"].ToString();
                        shiwake.Kingaku = d;
                        shiwake.KsKmkName = row["F11"].ToString();
                        shiwake.KsHKmkName = row["F12"].ToString();
                        shiwake.Tekiyo = row["F17"].ToString();
                        Static.ShiwakeDs.Shiwake.AddShiwakeRow(shiwake);
                    }

                    rowNo++;
                }

                // エラーデータは、ファイルで出力
                var errorRows = dt.Select("Error <> ''");

                var sb = new StringBuilder();
                foreach (DataRow row in errorRows)
                {
                    string rowLine = "";
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (col.ColumnName == "Error")
                        {
                            rowLine += row[col.ColumnName].ToString().ToDoubleQuote();
                        }
                        else
                        {
                            rowLine += row[col.ColumnName].ToString().ToDoubleQuote() + ",";
                        }
                    }
                    sb.AppendLine(rowLine);
                }

                using (var stream = new System.IO.StreamWriter(path + ".err"))
                {
                    stream.Write(sb.ToString(), false, Encoding.GetEncoding("SJIS"));
                }

                // 処理を終了
                if (errorRows.Count() == 0)
                {
                    MessageBox.Show("取込が正常に終了しました。", "CSV取込", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("取込が正常に終了しました。\n [ 取込エラー行は、.err として、出力されました。 ] ", "CSV取込", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                SaveShiwakeXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CSV取込エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReadShiwakeXML();
            }
        }

        #endregion

        #region 仕訳年度を取得
        /// <summary>
        /// 仕訳年度を選択できる年度のリストを作成する
        /// </summary>
        /// <returns></returns>
        public static List<string> GetShiwakeNendos()
        {
            var list = new List<string>();

            // 仕訳ファイルのXMLを読み込む
            if (System.IO.Directory.Exists(@"xml\shiwake"))
            {
                var dir = new System.IO.DirectoryInfo(@"xml\shiwake");
                foreach (var file in dir.GetFiles(@"*.xml"))
                {
                    int o;
                    string nendo = file.Name.Replace(".xml", "");
                    if (int.TryParse(nendo, out o) && nendo.Length == 4)
                    {
                        list.Add(nendo);
                    }
                }
            }

            // 前年＋当年は指定できる
            var date = DateTime.Now;
            if (!list.Any(x => x.CompareTo(date.Year.ToString()) == 0))
            {
                list.Add(date.Year.ToString());
            }
            if (!list.Any(x => x.CompareTo((date.Year - 1).ToString()) == 0))
            {
                list.Add((date.Year - 1).ToString());
            }

            return list;
        }
        #endregion

        #region 仕訳データの保存／読み込み

        /// <summary>
        /// 仕訳データ保存
        /// </summary>
        /// <param name="dt"></param>
        public static void SaveShiwakeXML()
        {

            if (!System.IO.Directory.Exists(@"xml\shiwake"))
            {
                System.IO.Directory.CreateDirectory(@"xml\shiwake");
            }
            Static.ShiwakeDs.Shiwake.WriteXml(@"xml\shiwake\" + Static.Nendo.ToString() + ".xml");
            ShiwakeChanged();
        }

        /// <summary>
        /// 仕訳データ読み込み
        /// </summary>
        public static void ReadShiwakeXML()
        {
            Static.ShiwakeDs.Shiwake.Clear();
            Static.ShiwakeDs.KeihiSum.Clear();
            Static.ShiwakeDs.ShisanSum.Clear();
            Static.ShiwakeDs.GenkinSuitocho.Clear();
            Static.ShiwakeDs.YokinSuitocho.Clear();

            if (System.IO.File.Exists(@"xml\shiwake\" + Static.Nendo.ToString() + ".xml"))
            {
                Static.ShiwakeDs.Shiwake.ReadXml(@"xml\shiwake\" + Static.Nendo.ToString() + ".xml");
            }
            ShiwakeChanged();
        }

        #endregion

        #region 残高データの保存／読込

        public static void SaveZandakaXML()
        {
            if (!System.IO.Directory.Exists(@"xml\zandaka"))
            {
                System.IO.Directory.CreateDirectory(@"xml\zandaka");
            }
            Static.ShiwakeDs.Zandaka.WriteXml(@"xml\zandaka\" + Static.Nendo.ToString() + ".xml");
            ShiwakeChanged();
        }

        /// <summary>
        /// 残高データの読込
        /// </summary>
        public static void ReadZandakaXML()
        {
            Static.ShiwakeDs.Zandaka.Clear();
            if (System.IO.File.Exists(@"xml\zandaka\" + Static.Nendo.ToString() + ".xml"))
            {
                Static.ShiwakeDs.Zandaka.ReadXml(@"xml\zandaka\" + Static.Nendo.ToString() + ".xml");
            }
            ShiwakeChanged();
        }

        #endregion

        #region Excel出力

        public static void ExcelOutput(string tableName)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                // 初期表示するディレクトリを設定する
                saveDialog.InitialDirectory = @"C:\";
                saveDialog.FileName = Static.Nendo.ToString() + "_" + tableName + ".xlsx";
                saveDialog.Filter = "テキスト ファイル|*.xlsx";

                var result = saveDialog.ShowDialog(Static.ParentForm);
                if (result == DialogResult.OK)
                {
                    var dt = ShiwakeDs.Tables[tableName];

                    using (var xls = new XLWorkbook())
                    {
                        xls.Worksheets.Add(dt);
                        xls.SaveAs(saveDialog.FileName);

                        MessageBox.Show("Excelを出力しました。", "出力", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
        #endregion

    }
}
