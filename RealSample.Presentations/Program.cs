using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealSample.Presentations.Views;
using RealSample.DBUtilities;

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
            DBInitialize initializer = new DBInitialize();
            initializer.TryExecuteScript("RealSample.Presentations.migration_init.sql");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}