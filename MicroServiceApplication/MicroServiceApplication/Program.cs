using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MicroServiceApplication
{
    static class Program
    {
        //测试分支现在是在yyt3中
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //登录
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            //选择机构
            SelectInstForm selectInstForm = new SelectInstForm();
            selectInstForm.ShowDialog();
            if (selectInstForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            //打开主界面
            MainForm mf = new MainForm();
                
            Application.Run(mf);

            //Application.Run(new MainForm());
        }
    }
}
