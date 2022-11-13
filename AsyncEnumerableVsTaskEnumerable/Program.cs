using BenchmarkDotNet.Running;

namespace AsyncEnumerableVsTaskEnumerable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}