using Microsoft.EntityFrameworkCore;
using poprawa_kolokwium_S18288.Entities;

namespace poprawa_kolokwium_S18288.Persistance
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
                .HasMany(p => p.Members)
                .WithOne(p => p.Organization);

            modelBuilder.Entity<Organization>()
                .HasMany(p => p.Teams)
                .WithOne(p => p.Organization);

            modelBuilder.Entity<Member>()
                .HasMany(p => p.Memberships)
                .WithOne(p => p.Member);

            modelBuilder.Entity<Team>()
                .HasMany(p => p.Files)
                .WithOne(p => p.Team);

            modelBuilder.Entity<Team>()
                .HasMany(p => p.Memberships)
                .WithOne(p => p.Team);
        }
    }
}
