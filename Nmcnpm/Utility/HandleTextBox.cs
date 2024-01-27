using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Utility
{
    public static class HandleTextBox
    {
        public static void HandleTextBox_Load(Control sender)
        {
            if (sender is TextBox)
            {
                sender.KeyPress += keyPress;
            }
            else if(sender.Controls.Count!=0)
            foreach (Control control in sender.Controls)
            {
                HandleTextBox_Load(control);
            }    
            
        }

        private const string NotAllowed = @":*!^?_;,.><@{}[]#&()'/|*+$%~\`";
        public static void keyPress(object sender, KeyPressEventArgs e)
        {
            if(NotAllowed.Contains(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        public static void xoaTextBox(Control sender)
        {
            if (sender is TextBox)
            {
                sender.Text = "";
            }
            else if (sender.Controls.Count != 0)
                foreach (Control control in sender.Controls)
                {
                    xoaTextBox(control);
                }
        }
    }
}
