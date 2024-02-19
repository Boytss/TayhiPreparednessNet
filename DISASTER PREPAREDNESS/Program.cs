using DISASTER_PREPAREDNESS.AdminForms;
using DISASTER_PREPAREDNESS.Forms;
using System.Configuration;

namespace DISASTER_PREPAREDNESS
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
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            
            Application.Run(new AdminDashboard());
           
        }
    }
}