using System;
using System.Windows.Forms;

namespace YayoiCsv
{
    /// <summary>
    /// 年度を変更するフォームクラス
    /// </summary>
    public partial class InputNendo : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputNendo()
        {
            InitializeComponent();

            // フォームの初期値設定
            InitializeForm();
        }

        /// <summary>
        /// 画面の初期設定
        /// </summary>
        void InitializeForm()
        {
            // 表示できる年度を設定
            Static.GetShiwakeNendos().ForEach(x => cmbNendo.Items.Add(x));
            cmbNendo.SelectedItem = Static.Nendo.ToString();
        }

        /// <summary>
        /// 年度を決定する
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void btnNendoSelect_Click(object sender, EventArgs e)
        {

            if (cmbNendo.SelectedItem == null || cmbNendo.SelectedItem.ToString() == "")
            {
                return;
            }

            Static.Nendo = int.Parse(cmbNendo.SelectedItem.ToString());
            Static.CloseChildForm(this.GetType());
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
    }
}
