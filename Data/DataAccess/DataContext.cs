using System.Data.Entity;
using Data.Entities;

namespace Data.DataAccess
{
    public class DataContext : DbContext
    {
        //public DataContext() : base("SqliteConnection") {}
        public DataContext() : base("MsLocaldbConnection") {}

        public DbSet<Worker> Workers { get; set; }
        public DbSet<AccessGroup> AccessGroups { get; set; }
    }
}
