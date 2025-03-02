using AlarmZoneApp.Services;
using System;
using System.Windows.Forms;

namespace AlarmZoneApp
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

            IZoneService zoneService = new ZoneService();
            Application.Run(new ZoneForm(zoneService));
        }
    }
}
