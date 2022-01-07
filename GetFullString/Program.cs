using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace GetFullString
{
    class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<Demo>();
        }
    }


    [SimpleJob(RuntimeMoniker.Net50, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark]
        public string GetFullStringNormally()
        {
            var output = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                output += i;
            }
            return output;
        }

        [Benchmark]
        public string GetFullStringWithStringBuilder()
        {
            var output = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                output.Append(i);
            }
            return output.ToString();
        }
    }
}
