using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace YayoiCsv
{
    /// <summary>
    /// 親画面
    /// </summary>
    public partial class MDIParent : Form
    {
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title
        {
            set
            {
                this.Text = value;
            }
        }

        public void MenuEnabled(bool enabled)
        {
            foreach (ToolStripMenuItem item in this.menuStrip.Items)
            {
                if (item.Name != "fileMenu")
                {
                    item.Enabled = enabled;
                }
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MDIParent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面起動
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">event</param>
        private void MDIParent_Load(object sender, EventArgs e)
        {
            if (Static.Nendo == 0)
            {
                MenuEnabled(false);

                Static.ShowChildForm(typeof(InputNendo));
            }
        }

        /// <summary>
        /// 経費入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miShiwakeInput_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(InputKeihi));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miKotsuhiBatch_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(BatchKotsuhi));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miNendoSelect_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(InputNendo));
        }

        /// <summary>
        /// すべて閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var form in this.MdiChildren)
            {
                Static.CloseChildForm(form.GetType());
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 対象文字列を保存する
        /// </summary>
        /// <param name="target"></param>
        private bool IsSaveFile(bool isNew)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                // 初期表示するディレクトリを設定する
                saveDialog.InitialDirectory = @"C:\";
                saveDialog.FileName = Static.Nendo.ToString() + "年度_仕訳（弥生）_" + DateTime.Now.ToString("yyyyMMddhhmmss");
                saveDialog.Filter = "テキスト ファイル|*.csv";

                var result = saveDialog.ShowDialog(Static.ParentForm);
                if (result == DialogResult.OK)
                {

                    using (var writeFileStream = new System.IO.StreamWriter(saveDialog.FileName, false, System.Text.Encoding.GetEncoding("SJIS")))
                    {
                        writeFileStream.Write(Static.CreateYayoiCSVShiwake(isNew));
                        return true;
                    }
                }
            }
            return false;
        }

        private void miViewShiwake_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(ViewShiwake));
        }

        private void miInputUriage_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(InputUriage));
        }

        private void miYayoiCsvOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void miYayoiCsvImportAppend_Click(object sender, EventArgs e)
        {
            Static.AddShiwakeFromCSV(true);
        }

        private void miYayoiCsvImport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("経費が全て上書きされますが、よろしいですか？\n" +
               "※ＣＳＶ出力（データのバックアップ）してから、実行することをお勧めします。", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Static.AddShiwakeFromCSV(false);
            }
        }

        private void MDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Static.WriteNendo();
        }

        private void 資産照会ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(ViewShisan));
        }

        private void miGenkinSuitocho_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(ViewGenkinSuitocho));
        }

        private void MDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Static.SaveFormPosition();
        }

        private void miYokinSuitocho_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(ViewYokinSuitocho));
        }

        private void miZandakaNyuryoku_Click(object sender, EventArgs e)
        {
            Static.ShowChildForm(typeof(InputKurikoshi));
        }

        private void miCsvOutputNew_Click(object sender, EventArgs e)
        {
            if (IsSaveFile(true))
            {
                MessageBox.Show("CSV出力しました。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miCsvOutputOld_Click(object sender, EventArgs e)
        {
            if (IsSaveFile(false))
            {
                MessageBox.Show("CSV出力しました。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
