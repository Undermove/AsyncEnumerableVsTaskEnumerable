using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace AsyncEnumerableVsTaskEnumerable
{
    public class Benchmarks
    {
        [Benchmark]
        public void Scenario1()
        {
            // Implement your benchmark here
        }

        [Benchmark]
        public void Scenario2()
        {
            // Implement your benchmark here
        }

        // Comparable versions
        // private async Task<List<T>> ReadAllAsync<T>(Func<DataReader, T> action, CancellationToken cancellationToken)
        // {
        //     var result = new List<T>();
        //     while (await _reader.ReadAsync(cancellationToken))
        //     {
        //         result.Add(action(new DataReader(_reader)));
        //     }
        //
        //     return result;
        // }
		      //
        // private async IAsyncEnumerable<T> ReadAllAsyncEnumerable<T>(Func<DataReader, T> action, [EnumeratorCancellation] CancellationToken cancellationToken)
        // {
        //     while (await _reader.ReadAsync(cancellationToken))
        //     {
        //         yield return action(new DataReader(_reader));
        //     }
        // }
    }
}