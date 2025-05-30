using Grupo4_Proyecto_final.Views.Admin;
using Grupo4_Proyecto_final.Views.Docente;
using Grupo4_Proyecto_final.Views.Login;
using System.Xml.Linq;

namespace Grupo4_Proyecto_final
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeDocenteForm(5,"ddfd", 4));
        }
    }
}