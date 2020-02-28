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
    ///  現金出納帳
    /// </summary>
    public partial class ViewGenkinSuitocho : control.FormEx
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ViewGenkinSuitocho()
        {
            InitializeComponent();
        }

        /// <summary>
        /// グリッドの初期処理
        /// </summary>
        private void InitGrid()
        {
            var dv = Static.ShiwakeDs.GenkinSuitocho.AsDataView();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Static.ExcelOutput(Static.ShiwakeDs.GenkinSuitocho.TableName);
        }
    }
}
