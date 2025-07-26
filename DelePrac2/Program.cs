using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

public class ExampleClass
{
    public delegate void DoSomething(int num);

    public DoSomething Something;

    public ExampleClass()
    {
        Something = FunctionOne;
      
    }
    public static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass();
        example.Something?.Invoke(456);
    }
    private void FunctionOne(int num)
    {
       Console.WriteLine($"FunctionOne called with value: {num}");

    }

}