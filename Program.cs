using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronics_Store_Program
{
    static class Program
    {
        public static log_in log_In;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log_In = new log_in();
            Application.Run(log_In);
        }
    }
}
