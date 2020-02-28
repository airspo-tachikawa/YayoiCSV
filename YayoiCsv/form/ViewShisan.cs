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
    ///  資産表示
    /// </summary>
    public partial class ViewShisan : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ViewShisan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// グリッドの初期処理
        /// </summary>
        private void InitGrid()
        {
            var dv = Static.ShiwakeDs.ShisanSum.AsDataView();
            dataGridView1.DataSource = dv;
        }

        private void InputShiwake_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            InitGrid();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Static.CloseChildForm(this.GetType());
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Static.ExcelOutput(Static.ShiwakeDs.ShisanSum.TableName);
        }
    }
}
