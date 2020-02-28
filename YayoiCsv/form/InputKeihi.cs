using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace YayoiCsv
{
    /// <summary>
    /// 経費入力
    /// </summary>
    public partial class InputKeihi : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputKeihi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// グリッドの初期処理
        /// </summary>
        private void InitGrid()
        {
            var dv = Static.ShiwakeDs.Shiwake.AsDataView();

            dv.Sort = "CustomDate ASC";
            dataGridView1.DataSource = dv;
            Search();
        }

        /// <summary>
        /// 科目名をセット
        /// </summary>
        private void SetKmkCombo()
        {
            cmbKmkSrch.Items.Clear();
            cmbKmk_Kr.Items.Clear();

            var kmk = Static.KmkList.Where(x => x.KmkKbn == KmkKbn.経費.ToString()).Select(x => x.KmkName).ToArray();

            cmbKmkSrch.Items.Add("");
            cmbKmkSrch.Items.AddRange(kmk);
            cmbKmk_Kr.Items.AddRange(kmk);
        }

        private void InputShiwake_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            SetKmkCombo();
            InitGrid();
            btnRepair.Enabled = false;

        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Static.CloseChildForm(this.GetType());
        }

        /// <summary>
        /// 補助科目のコンボボックスの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKmk_Kr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKmk_Kr.SelectedIndex != -1)
            {
                cmbHKmk_Kr.Text = "";
                cmbHKmk_Kr.Items.Clear();
                cmbHKmk_Kr.Items.AddRange(Static.HKmkList.Where(x => x.KmkName == cmbKmk_Kr.SelectedItem.ToString()).Select(x => x.HKmkName).ToArray());
            }
        }

        /// <summary>
        /// 補助科目のコンボボックスの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKmkSrch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKmkSrch.SelectedIndex != -1)
            {
                cmbHKmkSrch.Text = "";
                cmbHKmkSrch.Items.Clear();
                cmbHKmkSrch.Items.AddRange(Static.HKmkList.Where(x => x.KmkName == cmbKmkSrch.SelectedItem.ToString()).Select(x => x.HKmkName).ToArray());
            }
            Search();
        }

        /// <summary>
        /// 一覧クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int no = (int)dataGridView1.CurrentRow.Cells[colNo.Name].Value;
            var shiwake = Static.ShiwakeDs.Shiwake.Where(x => x.No == no).First();

            if (dataGridView1.Columns[e.ColumnIndex].Name == colUpd.Name)
            {
                // 修正
                txtNo.Text = shiwake.No.ToString();                       // 連番
                cmbKmk_Kr.SelectedItem = shiwake.KrKmkName;               // 科目名（借方）
                cmbHKmk_Kr.Text = shiwake.KrHKmkName;                     // 補助科目名（借方）
                txtHi.Text = shiwake.CustomDate;                          // 取引日
                txtKin.Text = shiwake.Kingaku.ToString();                 // 金額
                txtTekiyo.Text = shiwake.Tekiyo;                          // 摘要
                btnRepair.Enabled = true;
                cmbKmk_Kr.Focus();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == colDel.Name)
            {
                // 削除
                shiwake.Delete();

                // XML 保存
                Static.SaveShiwakeXML();
            }
        }

        /// <summary>
        /// 追加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (!IsAdd())
            {
                return;
            }

            // 常に最大を足す
            int no = Static.GetShiwakeNo();
            var shiwake = Static.ShiwakeDs.Shiwake.NewShiwakeRow();

            shiwake.No = no;
            shiwake.KmkKbn = KmkKbn.経費.ToString();
            SetRow(shiwake);

            Static.ShiwakeDs.Shiwake.AddShiwakeRow(shiwake);

            // 日付と、金額だけ、クリアする
            txtHi.Text = "";
            // txtKin.Text = "";

            // XML 保存
            Static.SaveShiwakeXML();

            btnRepair.Enabled = false;
            cmbHKmk_Kr.Focus();

        }

        /// <summary>
        /// 修正
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRepair_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (!IsAdd())
            {
                return;
            }

            var shiwake = Static.ShiwakeDs.Shiwake.Where(x => x.No == int.Parse(txtNo.Text)).FirstOrDefault();
            SetRow(shiwake);

            // XML 保存
            Static.SaveShiwakeXML();

            btnRepair.Enabled = false;
            txtNo.Text = "";
            txtHi.Text = "";
            // txtKin.Text = "";
            cmbHKmk_Kr.Focus();

        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool IsAdd()
        {
            if (cmbKmk_Kr.SelectedItem == null || cmbKmk_Kr.SelectedItem.ToString() == "")
            {
                MessageBox.Show("科目名称（借方）は必須項目です。\n科目名称（借方）を選択して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbKmk_Kr.Focus();
                return false;
            }

            if (txtHi.Text.Trim() == "")
            {
                MessageBox.Show("日付は必須項目です。\n日付を入力して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHi.Text = "";
                txtHi.Focus();
                return false;
            }

            if (txtHi.Text.Length != 4)
            {
                MessageBox.Show("日付は月を２ケタ、日を２ケタで入力して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHi.Text = "";
                txtHi.Focus();
                return false;
            }

            DateTime dt;
            if (!DateTime.TryParse(Static.Nendo + "/" +　txtHi.Text.Substring(0, 2) + "/" + txtHi.Text.Substring(2, 2), out dt))
            {
                MessageBox.Show("日付が間違っています。\n正しい日付を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHi.Text = "";
                txtHi.Focus();
                return false;
            }

            if (txtKin.Text.Trim() == "")
            {
                MessageBox.Show("金額は必須項目です。\n金額を入力して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKin.Text = "";
                txtKin.Focus();
                return false;
            }

            decimal de;
            if (!decimal.TryParse(txtKin.Text, out de))
            {
                MessageBox.Show("金額は数値で入力して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKin.Text = "";
                txtKin.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// DataTableにデータを保持
        /// </summary>
        /// <param name="shiwake">経費Row</param>
        private void SetRow(ShiwakeDs.ShiwakeRow shiwake)
        {
            shiwake.CustomDate = txtHi.Text;                          // 取引日
            shiwake.KrKmkName = cmbKmk_Kr.SelectedItem.ToString();    // 科目名（借方）
            shiwake.KrHKmkName = cmbHKmk_Kr.Text;                     // 補助科目名（借方）
            shiwake.KsKmkName = cmbKmk_Ks.SelectedItem.ToString();    // 科目名（貸方）
            shiwake.KsHKmkName = cmbHKmk_Ks.Text;                     // 補助科目名（貸方）
            shiwake.Kingaku = int.Parse(txtKin.Text);                 // 金額
            shiwake.Tekiyo = txtTekiyo.Text;                          // 摘要
            shiwake.Week = Static.GetWeekName(txtHi.Text);            // 曜日
        }

        private void cmbHKmkSrch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtDateSrch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbHKmkSrch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var dv = (DataView)dataGridView1.DataSource;
            string filter = "";
            filter = "KmkKbn = '" + KmkKbn.経費.ToString() + "'";
            if (cmbKmkSrch.SelectedItem != null && cmbKmkSrch.SelectedItem.ToString() != "")
            {
                filter += " and KrKmkName = '" + cmbKmkSrch.SelectedItem.ToString() + "'";
            }
            if (cmbHKmkSrch.Text.Trim() != "")
            {
                
                filter += " and KrHKmkName = '" + cmbHKmkSrch.Text + "'";
            }
            if (txtDateSrch.Text.Trim() != "" && txtDateSrch.Text.Length == 2)
            {
                filter += " and CustomDate like '" + txtDateSrch.Text + "%'";
            }
            if (txtDateSrch.Text.Trim() != "" && txtDateSrch.Text.Length == 4)
            {
                filter += " and CustomDate = '" + txtDateSrch.Text + "'";
            }

            dv.RowFilter = filter;
        }
    }
}
