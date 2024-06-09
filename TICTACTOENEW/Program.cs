using System;
using System.Windows.Forms;

namespace TicTacToe
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Administrator defaultAdmin = new Administrator("endran", "admin", "admin123");

            Application.Run(new LoginForm(defaultAdmin));
        }
    }
}
