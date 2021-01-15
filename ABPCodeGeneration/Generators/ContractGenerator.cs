using System;
using System.Collections.Generic;
using System.Text;

namespace ABPCodeGeneration.Generators
{
    public class ContractGenerator : AbsGenerator
    {
        public override string GetPath()
        {
            return $@"{GetBasePath()}\{ClassInfo.Namespace.Split('.')[0]}.Application.Contracts\{ClassInfo.Namespace.Split('.')[1]}\{ClassInfo.Name}AppService.cs";
        }

        public override string GetTemplet()
        {
            return $@"using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace QuestionnaireInvestigation.Questions
{{
    public class AnswerDto : AuditedEntityDto<Guid>
    {{
        public string Answser {{ get; set; }}
    }}
}}
";
        }
    }
}
