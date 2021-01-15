using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace QuestionnaireInvestigation.Questions
{
    public class Answer : AuditedAggregateRoot<Guid> 
    {
        public string Answser { get; set; }
    }
}
