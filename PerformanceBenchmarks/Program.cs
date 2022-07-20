using BenchmarkDotNet.Running;
using PerformanceBenchmarks.Strings;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<HelloString>();
Console.ReadLine();
