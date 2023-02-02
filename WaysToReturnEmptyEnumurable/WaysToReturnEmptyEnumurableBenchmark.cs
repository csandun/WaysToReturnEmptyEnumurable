using BenchmarkDotNet.Attributes;

namespace WaysToReturnEmptyEnumurable;

public abstract record class Person(int Id, string Name, int Age);

[MemoryDiagnoser()]
public class WaysToReturnEmptyEnumurableBenchmark
{
    [Benchmark]
    public void CreateEmptyList()
    {
        IEnumerable<Person> list = new List<Person>();
    }
    
    [Benchmark]
    public void CreateEmptyListWithCapacity()
    {
        IEnumerable<Person> list = new List<Person>(0);
    }
    
    [Benchmark]
    public void StaticEmptyMethod()
    {
        IEnumerable<Person> list =  Enumerable.Empty<Person>();
    }
}

//var summary = BenchmarkRunner.Run<WaysToReturnEmptyEnumurableBenchmark>();