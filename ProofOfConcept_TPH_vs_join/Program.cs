using BenchmarkDotNet.Running;

namespace ProofOfConcept_TPH_vs_2_queries
{
    internal class Program
    {
        public static string ConnectionString = "Host=localhost;Port=5432;Database=tph_vs_join;Username=gk;Password=admin";

        static void Main(string[] args)
        {

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run();
        }
    }
}
