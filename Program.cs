namespace Notas
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

            //Form1View view = new()
            //NotasPresemtador presenter = new Presentador()
            //view.setPresenter(presenter)
            //Application.Run(view)

            Application.Run(new NotasView());
        }
    }
}