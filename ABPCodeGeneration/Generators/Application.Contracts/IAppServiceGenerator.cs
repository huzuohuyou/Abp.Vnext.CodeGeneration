using System;
using System.Collections.Generic;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public class IAppServiceGenerator : AbsGenerator
    {
        public override string GetDir()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application.Contracts\{ClassInfo.Namespace.Split('.')[1]}\";
        }
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application.Contracts\{ClassInfo.Namespace.Split('.')[1]}\I{ClassInfo.Name}AppService.cs";
        }

        public override string GetTemplet()
        {
            return $@"using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace {ClassInfo.Namespace}
{{
    public interface I{ClassInfo.Name}AppService :
        ICrudAppService< 
            {ClassInfo.Name}Dto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdate{ClassInfo.Name}Dto> 
    {{
    }}
}}

";
        }
    }
}
