using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;
using ProofOfConcept_TPH_vs_2_queries.Entities;

namespace ProofOfConcept_TPH_vs_2_queries
{
    [MemoryDiagnoser]
    public class Benchmark
    {

        public int Rows { get; set; } = 10000;

        [GlobalSetup(Target = nameof(Typical))]
        public async Task SetupTypicalAsync()
        {
            Console.WriteLine("Preparing db");

            using var context = new TypicalDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            await context.SeedAsync(Rows);

            Console.WriteLine("Prepared");

        }

        [GlobalSetup(Target = nameof(Tph))]
        public async Task SetupTphAsync()
        {
            Console.WriteLine("Preparing db");

            using var context = new TphDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            await context.SeedAsync(Rows);

            Console.WriteLine("Prepared");
        }

        [Benchmark]
        public async Task Typical()
        {
            using var context = new TypicalDbContext();

            var type = await context.EntityTypes.FirstOrDefaultAsync(x => x.Name == "2");

            if (type is null) return;

            var id = Rows - 1;

            EntityTyped? entity = null;

            switch (type.Type)
            {
                case "3":
                    entity = await context.Entities24.FirstOrDefaultAsync(x => x.Id == id);
                    break;

                case "2":
                    entity = await context.Entities23.FirstOrDefaultAsync(x => x.Id == id);
                    break;

                case "1":
                    entity = await context.Entities22.FirstOrDefaultAsync(x => x.Id == id);
                    break;

                case "0":
                    entity = await context.Entities21.FirstOrDefaultAsync(x => x.Id == id);
                    break;
            }

            Console.WriteLine(entity?.Id);

        }

        [Benchmark]
        public async Task Tph()
        {
            using var context = new TphDbContext();

            var id = Rows - 1;

            var res = await context.Entities.FirstOrDefaultAsync(x => x.Id == id);

            Console.WriteLine(res?.Id);
        }
    }
}
