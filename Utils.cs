using DominandoEFCore.Data;

namespace DominandoEFCore
{
    public static class Utils
    {
        public static void EnsureCreatedAndDeleted()
        {
            using var db = new ApplicationContext();
            //db.Database.EnsureCreated();
            db.Database.EnsureDeleted();
        }
    }
}
