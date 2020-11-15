using System;
using CommandLine;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Arguments>(args)
                .WithParsed<Arguments>(arguments =>
                {
                    var n = arguments.Number;
                    var resultIterative = Factorial.CalculateIterative(n);
                    Console.WriteLine(Factorial.FormatResult(n, resultIterative));
                    var resultRecursive = Factorial.CalculateRecursive(n);
                    Console.WriteLine(Factorial.FormatResult(n, resultIterative));
                });
        }
    }
}