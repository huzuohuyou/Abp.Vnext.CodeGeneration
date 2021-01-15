using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace QuestionnaireInvestigation.Questions
{
    public class QuestionDto : AuditedEntityDto<Guid>
    {
       public string Answser { get; set; }

    }
}

