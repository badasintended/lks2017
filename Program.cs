using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Forms;

namespace Nusantara
{
    static class Program
    {
        public static readonly Data.LKSEntities Entities = new Data.LKSEntities();

        public static Data.User User = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormLogin.GetInstance());
        }
    }
}
