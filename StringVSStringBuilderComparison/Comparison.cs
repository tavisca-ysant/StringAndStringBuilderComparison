using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace StringVSStringBuilderComparison
{
    
    [MemoryDiagnoser]
    public class Comparison
    {
        [Benchmark]
        

        public void StringPerformance()
        {
            string input = "";
            for (int i = 0; i < 1000; i++)
            {
                input += "a";
            }
            
        }

        [Benchmark]
        

        public void StringBuilderPerformance()
        {
            StringBuilder stringBuilder = new StringBuilder("a");
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append("a");
            }
            
        }
    }
}
