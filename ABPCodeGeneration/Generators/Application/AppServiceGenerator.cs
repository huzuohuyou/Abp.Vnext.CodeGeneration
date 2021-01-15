using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public class AppServiceGenerator : AbsGenerator
    {

        public override string GetDir()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application\{ClassInfo.Namespace.Split('.')[1]}\";
        }
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application\{ClassInfo.Namespace.Split('.')[1]}\{ClassInfo.Name}AppService.cs";
           
        }

        public override string GetTemplet()
        {
            return $@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace {ClassInfo.Namespace}
{{
    public class {ClassInfo.Name}AppService :
        CrudAppService<
            {ClassInfo.Name},
            {ClassInfo.Name}Dto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdate{ClassInfo.Name}Dto>,
        I{ClassInfo.Name}AppService
    {{
        public {ClassInfo.Name}AppService(IRepository<{ClassInfo.Name}, Guid> repository)
            : base(repository)
        {{

        }}
    }}
}}";
        }
    }
}
