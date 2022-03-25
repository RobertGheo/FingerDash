using FingerDash.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerDash
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
            Application.Run(new StartApp());
            //Application.Run(new MainForm());
            //Application.Run(new MenuManager());
            //Application.Run(new EmployeeRota());            
            //Application.Run(new ClockAlertMess());
            //Application.Run(new MenuAdmin());
        }
    }
}
