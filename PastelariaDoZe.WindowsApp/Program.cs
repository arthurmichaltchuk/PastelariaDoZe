using Autofac;
using PastelariaDoZe.Infra.Logger;
using PastelariaDoZe.WindowsApp;
using PastelariaDoZe.WindowsApp.Features.LoginFeature;
using PastelariaDoZe.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoFacDI.Container.Resolve<TelaLoginForm>().ShowDialog();
        }

    }
}
