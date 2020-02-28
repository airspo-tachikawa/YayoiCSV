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
    public partial class InputKurikoshi : control.FormEx
    {
        private BindingSource bindingSource;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public InputKurikoshi()
        {
            InitializeComponent();  
        }

        void bindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
            {
                e.Binding.BindingManagerBase.EndCurrentEdit();
            }
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
        /// 更新処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Click(object sender, EventArgs e)
        {
            Static.SaveZandakaXML();
            Static.ShiwakeChanged();
        }

        private void InputKurikoshi_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = Static.ShiwakeDs;
            bindingSource.DataMember = Static.ShiwakeDs.Zandaka.TableName;

            if (Static.ShiwakeDs.Zandaka.Count == 0)
            {
                Static.ShiwakeDs.Zandaka.AddZandakaRow(Static.ShiwakeDs.Zandaka.NewZandakaRow());
            }

            txtGenKin.DataBindings.Add("Text", bindingSource, "Genkin");
            txtYoKin.DataBindings.Add("Text", bindingSource, "Yokin");
            txtUrikake.DataBindings.Add("Text", bindingSource, "Urikake");
            bindingSource.BindingComplete += new BindingCompleteEventHandler(bindingSource_BindingComplete);
        }
    }
}
