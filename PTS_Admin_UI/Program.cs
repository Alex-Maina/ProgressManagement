namespace PTS_Admin_UI
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

            //initialize db connection
            PTSLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new AdminControlForm());
        }
    }
}