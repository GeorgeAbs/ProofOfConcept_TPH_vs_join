using Microsoft.EntityFrameworkCore;
using ProofOfConcept_TPH_vs_2_queries.Entities;

namespace ProofOfConcept_TPH_vs_2_queries
{
    public class TypicalDbContext : DbContext
    {
        public TypicalDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<EntityType> EntityTypes { get; set; } = null!;

        public DbSet<Entity21> Entities21 { get; set; } = null!;

        public DbSet<Entity22> Entities22 { get; set; } = null!;

        public DbSet<Entity23> Entities23 { get; set; } = null!;

        public DbSet<Entity24> Entities24 { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("queries_2");

            modelBuilder.Entity<EntityType>()
                .HasIndex(x => x.Name)
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Program.ConnectionString);
        }

        public async Task SeedAsync(int rows)
        {
            for (int i = 0; i < 4; i++)
            {
                var entityType = new EntityType { Name = $"Entity type name {i}" };

                switch (i)
                {
                    case 0:
                        Set<Entity21>().AddRange(Enumerable.Range(0, rows).Select(x => new Entity21 {EntityType = entityType, F12 = x, F13 = x, F14 = x, F15 = x, F16 = x }));
                        break;
                    case 1:
                        Set<Entity22>().AddRange(Enumerable.Range(0, rows).Select(x => new Entity22 { EntityType = entityType, F22 = x, F23 = x, F24 = x, F25 = x, F26 = x }));
                        break;
                    case 2:
                        Set<Entity23>().AddRange(Enumerable.Range(0, rows).Select(x => new Entity23 { EntityType = entityType, F32 = x, F33 = x, F34 = x, F35 = x, F36 = x }));
                        break;
                    case 3:
                        Set<Entity24>().AddRange(Enumerable.Range(0, rows).Select(x => new Entity24 { EntityType = entityType, F42 = x, F43 = x, F44 = x, F45 = x, F46 = x }));
                        break;
                }

            }

            await SaveChangesAsync();
        }
    }
}
