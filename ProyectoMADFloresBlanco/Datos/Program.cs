using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMADFloresBlanco
{
    internal static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InicioSesion());

           InicioSesion VenInicioSesion = new InicioSesion();
            VenInicioSesion.FormClosed += MainForm_Closed;
            VenInicioSesion.Show();
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
