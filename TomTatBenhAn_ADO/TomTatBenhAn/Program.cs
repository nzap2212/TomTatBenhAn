using UI.Forms;
using Services;
using System.Runtime.CompilerServices;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            await ReadConfigGoogleSheet.Instance.GetConfig();
            Application.Run(LoginForm.Instance);
        }
    }
}