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
        Something = FunctionTwo;
      
    }
    public static void Main(string[] args)
    {
        ExampleClass example = new ExampleClass();
        example.Something?.Invoke(456);
        example.Something?.Invoke(123);
    }
    private void FunctionOne(int num)
    {
       Console.WriteLine($"FunctionOne called with value: {num}");

    }

    private void FunctionTwo(int num)
    {
        Console.WriteLine($"FunctionTwo called with value: {num}");
    }



}