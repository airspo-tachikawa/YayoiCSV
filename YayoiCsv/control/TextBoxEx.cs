using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YayoiCsv.control
{
    public enum InputType
    {
        String,
        Number,
        Date
    }
    

    public partial class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 入力タイプ
        /// </summary>
        [Browsable(true)]
        [Description("入力タイプ")]
        [Category("動作")]
        public InputType InputType { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            SelectAll();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (InputType == InputType.Number || InputType == InputType.Date)
            {
                Text = new Regex("[^0-9]").Replace(Text, ""); 
            }

        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            Text = Text.Trim();

            if (this.InputType == InputType.Number)
            {
                Text = new Regex("[^0-9]").Replace(Text, "");
            }

            if (this.InputType == InputType.Date)
            {
                if (Text.Length == 3)
                {
                    if (int.Parse(Text.Substring(0 ,1)) > 1)
                    {
                        Text = "0" + Text;
                    }
                }

                if (Text.Length == 4 || Text.Length == 2) 
                {
                    DateTime o;
                    string month = Text.Substring(0, 2);
                    string day = Text.Length == 4 ? Text.Substring(2, 2) : "01";
                    if (!DateTime.TryParse(Static.Nendo.ToString() + "/" + month + "/" + day, out o))
                    {
                        Text = "";
                    }
                }
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SendKeys.SendWait("{TAB}");
            //    e.Handled = true;
            //}

        }

    }
}
