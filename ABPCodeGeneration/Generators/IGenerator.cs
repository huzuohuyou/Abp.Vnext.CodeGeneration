using System;
using System.Collections.Generic;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public interface IGenerator
    {
        string GetPath();
        string GetTemplet();
       
    }
}
