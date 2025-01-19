using BenchmarkDotNet.Running;

namespace ProofOfConcept_TPH_vs_2_queries
{
    internal class Program
    {
        public static string ConnectionString = string.Empty;

        static void Main(string[] args)
        {
            ConnectionString = "Host=localhost;Port=5432;Database=tph_vs_join;Username=gk;Password=admin";

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run();
        }
    }
}
