using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YayoiCsv.control
{
    public class FormEx : System.Windows.Forms.Form
    {
        [UIPermission(SecurityAction.Demand, Window = UIPermissionWindow.AllWindows)]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ActiveControl is Button || ActiveControl is DataGridViewEx)
            {
                return base.ProcessDialogKey(keyData);
            }

            if (((keyData & Keys.KeyCode) == Keys.Return) && ((keyData & (Keys.Alt | Keys.Control)) == Keys.None))
            {
                this.ProcessTabKey((keyData & Keys.Shift) != Keys.Shift);
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}
