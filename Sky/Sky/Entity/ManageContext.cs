using Microsoft.EntityFrameworkCore;

namespace Sky.Entity
{
    public class ManageContext : DbContext
    {
        public ManageContext(DbContextOptions<ManageContext> options) : base(options)
        {

        }
        public ManageContext() { }

        public virtual DbSet<Match> Matches { set; get; }
        public virtual DbSet<Player> Players { set; get; }
        public virtual DbSet<Stadium> Stadiums { set; get; }
        public virtual DbSet<Team> Teams { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasOne<Stadium>(m => m.Stadium).WithMany(s => s.Matches).HasForeignKey(m => m.IDStadium).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Player>().HasOne<Team>(p => p.Team).WithMany(t => t.Players).HasForeignKey(m => m.IDTeam).OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //refer: https://docs.microsoft.com/en-us/ef/core/querying/related-data#lazy-loading
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
                var connectionString = configuration.GetConnectionString("ManageDb");
                //refer at https://docs.microsoft.com/en-us/ef/core/querying/related-data#include-on-derived-types
                //pacakge: Microsoft.EntityFrameworkCore.SqlServer
                optionsBuilder.UseSqlServer(connectionString).ConfigureWarnings(warning => warning.Throw());
            }
        }
    }
}
