﻿using ABPCodeGeneration.Generators;
using System;

namespace ABPCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppServiceGenerator().Do();
            new DtoGenerator().Do();
            new CreateUpdateDtoGenerator().Do();
            new IAppServiceGenerator().Do();
            Console.WriteLine("Hello World!");
        }
    }
}
