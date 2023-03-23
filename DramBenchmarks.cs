using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class DramBenchmarks
{
    private const int N = 5000;
    private const int M = 5000;

    [Benchmark]
    public void ByRows()
    {
        var tab = new int[N, M];
        for (var i = 0; i < N; i++)
        {
            for (var j = 0; j < M; j++)
            {
                tab[i, j] = 1;
            }
        }
    }
    
    [Benchmark]
    public void ByColumns()
    {
        var tab = new int[N, M];
        for (var i = 0; i < N; i++)
        {
            for (var j = 0; j < M; j++)
            {
                tab[j, i] = 1;
            }
        }
    }
}