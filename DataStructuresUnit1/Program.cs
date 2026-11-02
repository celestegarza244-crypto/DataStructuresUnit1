namespace DataStructuresUnit1;

internal static class Program
{
    /// <summary>
    /// Application entry point.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // Reads the application-wide settings (high DPI, default font, visual styles).
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
