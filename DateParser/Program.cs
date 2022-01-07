using BenchmarkDotNet.Running;

namespace DateParser;

class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<DateParserBenchmarks>();
    }
}