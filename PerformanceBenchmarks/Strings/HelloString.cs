using BenchmarkDotNet.Attributes;

namespace PerformanceBenchmarks.Strings
{
    [MemoryDiagnoser]//该特性会在测试报告中追加，2个方法执行时的内存使用情况,Allocated表明了内存占用情况
    public class HelloString
    {
        [Benchmark]
        public void IntToString()
        {
            Enumerable.Range(-101, 101).ToList().ForEach(x => Awesome.BasicTips.HelloString.IntToString(x));
        }
    }
}
