namespace Mirage;

internal static class Program
{
	[STAThread]
    public static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMainMenu());
    }
}