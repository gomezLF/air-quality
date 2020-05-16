using System;
using System.Windows.Forms;

namespace userInterface
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainMenu mainMenu = new MainMenu();
            mainMenu.FormClosed += MainMenu_Closed; // agrega esto aquí
            mainMenu.Show();
            Application.Run();
        }

        private static void MainMenu_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainMenu_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainMenu_Closed;
            }
        }
    }
}
