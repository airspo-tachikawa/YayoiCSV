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
    /// 売上入力
    /// </summary>
    public partial class InputUriage : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputUriage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// グリッドの初期処理
        /// </summary>
        private void InitGrid()
        {
            var dv = Static.ShiwakeDs.Shiwake.AsDataView();

            dv.RowFilter = "KmkKbn = '" + KmkKbn.資産.ToString() + "'";
            dv.Sort = "CustomDate ASC";
            dataGridView1.DataSource = dv;
        }

        /// <summary>
        /// 科目名をセット
        /// </summary>
        private void SetKmkCombo()
        {
            cmbKmk_Kr.Items.Clear();
            var kmk = Static.KmkList.Where(x => x.KmkKbn == "資産").Select(x => x.KmkName).ToArray();
            cmbKmk_Kr.Items.AddRange(kmk);
            cmbKmk_Ks.Items.AddRange(kmk);
        }

        private void InputUriage_Load(object sender, EventArgs e)
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
                cmbKmk_Ks.SelectedItem = shiwake.KsKmkName;               // 科目名（貸方）
                cmbHKmk_Ks.Text = shiwake.KsHKmkName;                     // 補助科目名（貸方）
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
            int no = Static.ShiwakeDs.Shiwake.Count() == 0 ? 1 : Static.ShiwakeDs.Shiwake.Max(x => x.No) + 1;
            var shiwake = Static.ShiwakeDs.Shiwake.NewShiwakeRow();

            shiwake.No = no;
            shiwake.KmkKbn = KmkKbn.資産.ToString();
            SetRow(shiwake);

            Static.ShiwakeDs.Shiwake.AddShiwakeRow(shiwake);

            // 日付と、金額だけ、クリアする
            txtHi.Text = "";

            // XML 保存
            Static.SaveShiwakeXML();

            btnRepair.Enabled = false;
            txtHi.Focus();

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
            if (!DateTime.TryParse(Static.Nendo + "/" + txtHi.Text.Substring(0, 2) + "/" + txtHi.Text.Substring(2, 2), out dt))
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
            if (cmbKmk_Ks.SelectedItem == null || cmbKmk_Ks.SelectedItem.ToString() == "")
            {
                MessageBox.Show("科目名称（貸方）は必須項目です。\n科目名称（借方）を選択して下さい。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbKmk_Ks.Focus();
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
        private void SetRow(ShiwakeDs.ShiwakeRow shisan)
        {
            shisan.CustomDate = txtHi.Text;                          // 取引日
            shisan.KrKmkName = cmbKmk_Kr.SelectedItem.ToString();    // 科目名（借方）
            shisan.KrHKmkName = cmbHKmk_Kr.Text;                     // 補助科目名（借方）
            shisan.KsKmkName = cmbKmk_Ks.SelectedItem.ToString();    // 科目名（貸方）
            shisan.KsHKmkName = cmbHKmk_Ks.Text;                     // 補助科目名（貸方）
            shisan.Kingaku = int.Parse(txtKin.Text);                 // 金額
            shisan.Tekiyo = txtTekiyo.Text;                          // 摘要
            shisan.Week = Static.GetWeekName(txtHi.Text);            // 曜日
        }

        private void cmbKmk_Ks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKmk_Ks.SelectedIndex != -1)
            {
                cmbHKmk_Ks.Text = "";
                cmbHKmk_Ks.Items.Clear();
                cmbHKmk_Ks.Items.AddRange(Static.HKmkList.Where(x => x.KmkName == cmbKmk_Ks.SelectedItem.ToString()).Select(x => x.HKmkName).ToArray());
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUrikake.Checked)
            {
                // 売掛金
                cmbKmk_Kr.SelectedItem = "売掛金";
                cmbHKmk_Kr.Text = cmbHKmk_Kr.Items[0].ToString();

                cmbKmk_Ks.SelectedItem = "売上高";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "売掛金として商品を販売";

            }
            else if (rdoGenkinUriage.Checked)
            {
                // 現金売上
                cmbKmk_Kr.SelectedItem = "現金";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "売上高";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "商品を現金で販売";

            }
            else if (rdoUrikakeKGenkin.Checked)
            {
                // 売掛金を現金回収
                cmbKmk_Kr.SelectedItem = "現金";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "売掛金";
                cmbHKmk_Ks.Text = cmbHKmk_Ks.Items[0].ToString();

                txtTekiyo.Text = "売掛金を現金で回収";
            }
            else if (rdoUrikakeKYokin.Checked)
            {
                // 売掛金を預金回収
                cmbKmk_Kr.SelectedItem = "普通預金";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "売掛金";
                cmbHKmk_Ks.Text = cmbHKmk_Ks.Items[0].ToString();

                txtTekiyo.Text = "売掛金が預金に振り込まれた";
            }
            else if (rdoYokinToGenkin.Checked)
            {
                // 預金→現金
                cmbKmk_Kr.SelectedItem = "現金";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "普通預金";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "預金から現金を引き出した";
            }
            else if (rdoGenkinToYokin.Checked)
            {
                // 現金→預金
                cmbKmk_Kr.SelectedItem = "普通預金";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "現金";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "現金を預金に振り込んだ";

            }
            else if (rdoGenkinToKojin.Checked)
            {
                // 現金→事業主
                cmbKmk_Kr.SelectedItem = "事業主貸";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "現金";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "事業資金の引き出し";
            }
            else if (rdoYokinToKojin.Checked)
            {
                // 現金→事業主
                cmbKmk_Kr.SelectedItem = "事業主貸";
                cmbHKmk_Kr.Text = "";

                cmbKmk_Ks.SelectedItem = "普通預金";
                cmbHKmk_Ks.Text = "";

                txtTekiyo.Text = "事業資金の引き出し";
            }

            btnRepair.Enabled = false;

            txtHi.Text = "";
            txtKin.Text = "";

            txtHi.Focus();
        }
    }
}
