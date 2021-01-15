using ABPCodeGeneration.Generators;
using System;

namespace ABPCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            new ApplicationGenerator().Do();
            new ContractDtoGenerator().Do();
            new ContractCreateUpdateDtoGenerator().Do();
            new ContractIServiceGenerator().Do();
            Console.WriteLine("Hello World!");
        }
    }
}
