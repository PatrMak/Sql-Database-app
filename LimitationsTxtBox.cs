using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sql_Database_app
{
    public class LimitationsTxtBox
    {
        public void OnlyPassNumericToTxtBox(object sender, KeyPressEventArgs eKey, bool bIsDotAccepted)
        {
            if (bIsDotAccepted)
            {
                if (!char.IsControl(eKey.KeyChar) && !char.IsDigit(eKey.KeyChar) &&
                    (eKey.KeyChar != '.'))
                {
                    eKey.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(eKey.KeyChar) && !char.IsDigit(eKey.KeyChar))
                {
                    eKey.Handled = true;
                }
            }

            if ((eKey.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                eKey.Handled = true;
            }
        }


        public void SetMaxNumberToTxtBox(ref object sender, int maxNumber)
        {
            int iTxtNumber;
            Int32.TryParse((sender as TextBox).Text, out iTxtNumber);

            if (iTxtNumber < 0 && (sender as TextBox).Text != "")
            {
                ShowMsgBox();
                (sender as TextBox).Text = null;
            }
            else if (iTxtNumber > maxNumber && (sender as TextBox).Text != "")
            {
                ShowMsgBox();
                (sender as TextBox).Text = null;
            }
        }

        private void ShowMsgBox()
        {
            string message = "Tool number out of range!";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            _ = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);


        }
    }
}
