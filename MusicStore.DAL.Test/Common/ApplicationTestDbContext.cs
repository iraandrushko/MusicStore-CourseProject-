using Microsoft.EntityFrameworkCore;

namespace MusicStore.DAL.Tests.Common
{
    public class ApplicationTestDbContext : ApplicationDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MusicStore_Test;Integrated Security=True");
        }
    }
}
