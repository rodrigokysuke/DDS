using App.Models.Entities;

namespace App.Models.Repositories
{
    internal class SessionRepository
    {
        private static readonly DdsDbContext ddsDbContext;

        static SessionRepository()
        {
            ddsDbContext = new DdsDbContext();
        }

        internal static Session? GetSession()
        {
            return ddsDbContext.Session.FirstOrDefault();
        }

        internal static void ClearSession()
        {
            ddsDbContext.Session.RemoveRange(ddsDbContext.Session);
            ddsDbContext.SaveChanges();
        }

        internal static void SetSession(Session session)
        {
            ddsDbContext.Session.Add(session);
            ddsDbContext.SaveChanges();
        }
    }
}
