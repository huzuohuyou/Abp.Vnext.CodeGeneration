using ABPCodeGeneration.Generators;
using System;

namespace ABPCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            new ApplicationAppServiceGenerator().Do();
            new ContractDtoGenerator().Do();
            new ContractCreateUpdateDtoGenerator().Do();
            new ContractIAppServiceGenerator().Do();
            Console.WriteLine("Hello World!");
        }
    }
}
