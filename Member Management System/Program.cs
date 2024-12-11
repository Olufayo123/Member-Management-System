using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Member_Management_System
{
    static class Program
    {
                
        [STAThread]
        // The attribute specifies that the application's COM threading model is single-threaded apartment (STA), which is essential for proper communication with COM components in Windows Forms applications.
        static void Main()
        {
            //First method to be executed when the program starts
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
