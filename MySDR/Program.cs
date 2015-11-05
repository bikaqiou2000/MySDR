using System;
using System.Windows.Forms;
using MySDR.Presenter;
using MySDR.View;

namespace MySDR
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //初始化对象
            var frmPm = new MainFormPM();
            var frm = new MainForm(frmPm);

            Application.Run(frm);
        }
    }
}