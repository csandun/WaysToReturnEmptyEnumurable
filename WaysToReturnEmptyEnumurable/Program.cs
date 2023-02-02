using BenchmarkDotNet.Running;
using WaysToReturnEmptyEnumurable;

var summary = BenchmarkRunner.Run<WaysToReturnEmptyEnumurableBenchmark>();