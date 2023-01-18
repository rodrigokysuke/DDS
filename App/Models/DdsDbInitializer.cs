
using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    internal class DdsDbInitializer
    {
        public static void Initialize()
        {
            var ddsDbContext = new DdsDbContext();

            //ddsDbContext.Database.EnsureDeleted();
            ddsDbContext.Database.EnsureCreated();

            ddsDbContext.Employees.Load();
            ddsDbContext.Events.Load();
            ddsDbContext.Signatures.Load();
            ddsDbContext.Session.Load();
        }
    }
}
