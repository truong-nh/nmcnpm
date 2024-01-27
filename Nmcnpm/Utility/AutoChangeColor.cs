using Nhom5.View.hokhau_nhankhau;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Utility
{
    public static class AutoChangeColor
    {
        //change color of usercontrol in secondScreen
        public static void changeColorScreen2(object sender, EventArgs e, List<String> list_type)
        {
            UserControl This_UC = sender as UserControl;
            if (This_UC.Visible)
            {
                try
                {
                    var secondScreenForm = This_UC.Parent as SecondScreen;
                    Button currentBtn = secondScreenForm.CurrentButton;
                    Color currentColor = currentBtn.BackColor;
                    foreach (Control btn in This_UC.Controls)
                    {
                        //Console.WriteLine(list_type.Contains("Button"));
                        if (list_type.Contains(btn.GetType().Name.ToString()))
                        {
                            btn.BackColor = currentColor;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        public static void changeSPanelScreen2(object sender, SPanel sPanel)
        {
            UserControl This_UC = sender as UserControl;
            if (This_UC.Visible)
            {
                try
                {
                    var secondScreenForm = This_UC.Parent as SecondScreen;
                    Button currentBtn = secondScreenForm.CurrentButton;
                    Color currentColor = currentBtn.BackColor;
                    sPanel.setFillColor(currentColor);
                    //Console.WriteLine(sPanel.Name+" "+currentColor);
                    foreach (Control label in sPanel.Controls)
                    {
                        label.BackColor = currentColor;
                    }    
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        // change color of second form function in second screen 
        public static void changeColorFuncScreen(object sender, EventArgs e, List<String> list_type)
        {
            FunctionForm this_Form = sender as FunctionForm;
            if (this_Form.Visible)
            {
                try
                {
                    var secondScreenForm = this_Form.parent_Form as SecondScreen;
                    Button currentBtn = secondScreenForm.CurrentButton;
                    Color currentColor = currentBtn.BackColor;
                    foreach (Control btn in this_Form.Controls)
                    {
                        //Console.WriteLine(list_type.Contains("Button"));
                        if (list_type.Contains(btn.GetType().Name.ToString()))
                        {
                            //Console.WriteLine(btn.Name);
                            btn.BackColor = currentColor;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public static void changeColorFuncScreen2(Form sender, Color currentColor, List<String> list_type)
        {
            Form this_Form = sender;
            if (this_Form.Visible)
            {
                try
                {
                    foreach (Control btn in this_Form.Controls)
                    {
                        //Console.WriteLine(list_type.Contains("Button"));
                        if (list_type.Contains(btn.GetType().Name.ToString()))
                        {
                            //Console.WriteLine(btn.Name);
                            btn.BackColor = currentColor;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
