namespace Vue_Icons
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // يخلي التطبيق ما يغيّر Layout مع DPI، وويندوز يكبّره بثبات
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}