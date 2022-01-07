using System.Text;
using BenchmarkDotNet.Attributes;
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
