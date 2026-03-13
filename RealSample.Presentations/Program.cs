using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealSample.Presentations.Views;

namespace RealSample.Presentations
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}