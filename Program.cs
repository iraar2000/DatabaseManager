using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager.View;
using DatabaseManager.Presentation;
using DatabaseManager.Model;

namespace DatabaseManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AdminLoginModel accountModel = new AdminLoginModel();  
            AdminLogin adminLoginView = new AdminLogin();
            AdminLoginServices adminLoginServices = new AdminLoginServices("C:\\Win32Study\\DBManager\\DatabaseManager\\Data\\");

            AdminLoginPresent adLogPresent = new AdminLoginPresent(adminLoginView, adminLoginServices, accountModel);

            Application.Run(adminLoginView);
        }
    }
}
