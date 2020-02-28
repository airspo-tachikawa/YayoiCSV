using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace YayoiCsv.control
{
    public partial class DataGridViewEx : DataGridView
    {
        public DataGridViewEx()
        {
            InitializeComponent();
        }
    
        /// <summary>
        /// セルの色を変更する
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (Columns[e.ColumnIndex].Name.IndexOf("Kingaku") >= 0)
            {
                decimal? kingaku = (decimal?)e.Value;

                if (kingaku != null && kingaku < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
            }
            else if (Columns[e.ColumnIndex].Name.IndexOf("Week") >= 0)
            {
                if (e.Value.ToString().CompareTo("土") == 0)
                {
                    this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                if (e.Value.ToString().CompareTo("日") == 0)
                {
                    this.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }
    }
}
