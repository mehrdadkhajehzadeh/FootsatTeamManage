using FootsalTeamManage.Entity;
using Microsoft.EntityFrameworkCore;

namespace FootsalTeamManage.persistance
{
    public class EFDataContext : DbContext
    {
        public DbSet<Team> teams {  get; set; }
        public DbSet<Player> players {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MEHRDAD;Initial Catalog=FootsalTeamManageDB; User Id=sa;Password=Mehrdad;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
