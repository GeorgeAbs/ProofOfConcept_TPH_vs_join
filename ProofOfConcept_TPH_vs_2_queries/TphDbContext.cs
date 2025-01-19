using Microsoft.EntityFrameworkCore;
using ProofOfConcept_TPH_vs_2_queries.Entities;

namespace ProofOfConcept_TPH_vs_2_queries
{
    public class TphDbContext : DbContext
    {
        public TphDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Entity> Entities { get; set; } = null!;
        public DbSet<EntityTph1> EntitiesTph1 { get; set; } = null!;
        public DbSet<EntityTph2> EntitiesTph2 { get; set; } = null!;
        public DbSet<EntityTph3> EntitiesTph3 { get; set; } = null!;
        public DbSet<EntityTph4> EntitiesTph4 { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Entity>().UseTphMappingStrategy();

            modelBuilder.HasDefaultSchema("tph");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Program.ConnectionString);
        }

        public async Task SeedAsync(int rows)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Set<EntityTph1>().AddRange(Enumerable.Range(0, rows).Select(x => new EntityTph1 { F12 = x, F13 = x, F14 = x, F15 = x, F16 = x}));
                        break;
                    case 1:
                        Set<EntityTph2>().AddRange(Enumerable.Range(0, rows).Select(x => new EntityTph2 { F22 = x, F23 = x, F24 = x, F25 = x, F26 = x }));
                        break;
                    case 2:
                        Set<EntityTph3>().AddRange(Enumerable.Range(0, rows).Select(x => new EntityTph3 { F32 = x, F33 = x, F34 = x, F35 = x, F36 = x }));
                        break;
                    case 3:
                        Set<EntityTph4>().AddRange(Enumerable.Range(0, rows).Select(x => new EntityTph4 { F42 = x, F43 = x, F44 = x, F45 = x, F46 = x }));
                        break;
                }
                
            }

            await SaveChangesAsync();
        }
    }

}
