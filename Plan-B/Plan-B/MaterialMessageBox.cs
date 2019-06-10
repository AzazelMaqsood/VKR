﻿using System.Windows.Forms;

namespace Plan_B
{    public static class MaterialMessageBox
    {
        public static DialogResult Show(string message,string caption, MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.YesNo:
                    using (frmYesNo yesNo = new frmYesNo())
                    {
                        yesNo.Text = caption;
                        yesNo.Message = message;
                        result = yesNo.ShowDialog();
                    }
                    break;

                case MessageBoxButtons.OK:
                    using (frmOK ok = new frmOK())
                    {
                        ok.Text = caption;
                        ok.Message = message;
                        result = ok.ShowDialog();
                    }
                    break;
            }
            return 0;
        }
    }
}
