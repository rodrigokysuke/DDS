using App.EnDecryption;
using App.Models;
using App.Screens.Home;
using App.Screens.Login;
using Microsoft.EntityFrameworkCore;

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

            var ddsDbContext = new DdsDbContext();

            //ddsDbContext.Database.EnsureDeleted();
            ddsDbContext.Database.EnsureCreated();

            ddsDbContext.Employees.Load();
            ddsDbContext.Events.Load();
            ddsDbContext.Signatures.Load();
            ddsDbContext.Session.Load();

            MetroFramework.Forms.MetroForm homeWindow = new Login();

            var session = ddsDbContext.Session.FirstOrDefault();
            if (session != null)
            {
                var employee = ddsDbContext.Employees.FirstOrDefault(e => e.Registration == session.Registration && e.Password == AesOperation.DecryptString(session.PasswordDecryptionKey, session.PasswordEncrypted));
                if (employee != null)
                {
                    homeWindow = new Home();
                }
            }

            Application.Run(homeWindow);
        }
    }
}