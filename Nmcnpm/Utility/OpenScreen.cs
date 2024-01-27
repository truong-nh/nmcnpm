using Nhom5.View.hokhau_nhankhau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Utility
{
    public static class OpenScreen
    {
        // dis_cls: 0 đóng form, !=0 disable form
        public static void openAnotherScreen(Object sender, Form formScreen, int dis_cls = 1)
        {
            void runSecondScreen()
            {
                Application.Run(formScreen);
            }
            Form curentForm = sender as Form;
            if (dis_cls == 0)
                curentForm.Close();
            else
                curentForm.Enabled = false;
            Thread th = new Thread(runSecondScreen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public static void openFunctionForm(UserControl sender, FunctionForm formScreen, int dis_cls = 1)
        {
            var startScreenForm = sender.Parent as SecondScreen;
            formScreen.getFormRef(startScreenForm);
            openAnotherScreen(startScreenForm, formScreen, dis_cls);
        }

        public static void openFunctionForm2(Form sender, Form formScreen, int dis_cls = 1)
        {
            openAnotherScreen(sender, formScreen, dis_cls);
        }

    }
}
