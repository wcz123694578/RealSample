using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealSample.Presentations.Views;
using RealSample.DBUtilities;
using RealSample.Ioc;
using RealSample.BLL.Abstractions;
using RealSample.BLL;
using RealSample.DAL.Abstractions;
using RealSample.DAL;

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
            try {
                DBInitialize initializer = new DBInitialize();
                initializer.TryExecuteScript(typeof(Program).Assembly, "RealSample.Presentations.migration_init.sql");

                ConfigureServices();

                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainView());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "未经处理的异常", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private static void ConfigureServices() {
            ServiceLocator.Register<IMediaFileDataService>(new MediaFileDataService());
            ServiceLocator.Register<IMediaFileBusinessService>(new MediaFileBusinessService());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            MessageBox.Show(e.Exception.Message, "未经处理的异常", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
    }
}