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
    ///  預金出納帳
    /// </summary>
    public partial class ViewYokinSuitocho : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ViewYokinSuitocho()
        {
            InitializeComponent();

        }

        private void InitCombo()
        {
            cmbKmk.Items.Clear();
            var kmk = Static.KmkList.Where(x => x.KmkKbn == KmkKbn.資産.ToString() && x.KmkName.IndexOf("預金") >= 0).Select(x => x.KmkName).ToArray();
            cmbKmk.Items.AddRange(kmk);
            cmbKmk.SelectedIndex = 0;
        }

        /// <summary>
        /// 補助科目のコンボボックスの変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKmk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKmk.SelectedIndex != -1)
            {
                cmbHKmk.Text = "";
                cmbHKmk.Items.Clear();
                cmbHKmk.Items.AddRange(Static.HKmkList.Where(x => x.KmkName == cmbKmk.SelectedItem.ToString()).Select(x => x.HKmkName).ToArray());
            }
            Search();
        }

        private void Search()
        {
            var dv = (DataView)dataGridView1.DataSource;

            string filter = "";
            filter += "     (KrKmkName = '" + cmbKmk.SelectedItem.ToString() + "' or KsKmkName = '" + cmbKmk.SelectedItem.ToString() + "')";
            filter += " and (KrHKmkName = '" + cmbHKmk.Text + "' or KsHKmkName = '" + cmbHKmk.Text + "')";
            
            dv.RowFilter = filter;
        }

        /// <summary>
        /// グリッドの初期処理
        /// </summary>
        private void InitGrid()
        {
            var dv = Static.ShiwakeDs.YokinSuitocho.AsDataView();
            dataGridView1.DataSource = dv;
        }

        private void InputShiwake_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitGrid();
            InitCombo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Static.CloseChildForm(this.GetType());
        }

        private void cmbHKmk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbHKmk_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Static.ExcelOutput(Static.ShiwakeDs.YokinSuitocho.TableName);
        }
    }
}
