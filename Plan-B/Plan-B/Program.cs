using System;
using System.Windows.Forms;

namespace Plan_B
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sotr());
        }

        public static string IsAdmin;

    }
}
