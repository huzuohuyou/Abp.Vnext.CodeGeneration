using System;
using System.Collections.Generic;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public class ContractCreateUpdateDtoGenerator : AbsGenerator
    {
        public override string GetDir()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application.Contracts\{ClassInfo.Namespace.Split('.')[1]}\";
        }
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application.Contracts\{ClassInfo.Namespace.Split('.')[1]}\CreateUpdate{ClassInfo.Name}Dto.cs";
        }

        public override string GetTemplet()
        {
            return $@"using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace {ClassInfo.Namespace}
{{
    public class CreateUpdate{ClassInfo.Name}Dto : AuditedEntityDto<Guid>
    {{
        {GetPropertysTemplet()}
    }}
}}
";

        }
    }
}
