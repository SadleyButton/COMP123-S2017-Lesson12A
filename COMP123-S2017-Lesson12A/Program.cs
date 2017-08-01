using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Name: Bradley Sutton
/// Date: Aug 01, 2017
/// Student Number: 300280496
/// Descprition: This is a Demo Application to showcase User Interface Controls
/// Version 0.1 - Created the Project
/// </summary>

namespace COMP123_S2017_Lesson12A
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
