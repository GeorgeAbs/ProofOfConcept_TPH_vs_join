using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace ProofOfConcept_TPH_vs_2_queries
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(100)]
        public int Rows { get; set; }

        [GlobalSetup(Target = nameof(RunTypicalAsync))]
        public async Task SetupTypicalAsync()
        {
            Console.WriteLine("Preparing db");

            using var context = new TypicalDbContext();

            await context.SeedAsync(Rows);

            Console.WriteLine("Prepared");

        }

        [GlobalSetup(Target = nameof(RunTphAsync))]
        public async Task SetupTphAsync()
        {
            Console.WriteLine("Preparing db");

            using var context = new TphDbContext();

            await context.SeedAsync(Rows);

            Console.WriteLine("Prepared");
        }

        [Benchmark]
        public async Task RunTypicalAsync()
        {
            using var context = new TypicalDbContext();

            await context.Entities21
                .Include(x => x.EntityType)
                .Where(x => x.EntityType.Id == 3)
                .ToListAsync();
        }

        [Benchmark]
        public async Task RunTphAsync()
        {
            using var context = new TphDbContext();

            await context.EntitiesTph4
                .ToListAsync();
        }
    }
}
