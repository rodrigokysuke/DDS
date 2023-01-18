using App.EnDecryption;
using App.Models;
using App.Models.Repositories;
using App.Screens;

namespace App
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
            DdsDbInitializer.Initialize();

            Form homeWindow = new Login();

            var session = SessionRepository.GetSession();
            if (session != null)
            {
                var employee = EmployeeRepository.GetEmployeeByLoginData(session.Registration, AesOperation.DecryptString(session.PasswordDecryptionKey, session.PasswordEncrypted));
                if (employee != null)
                {
                    homeWindow = new Screens.Main();
                }
            }

            Application.Run(homeWindow);
        }
    }
}