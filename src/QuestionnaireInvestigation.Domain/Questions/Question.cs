using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace QuestionnaireInvestigation.Questions
{
    public class Question : AuditedAggregateRoot<Guid>
    {
        public string Content { get; set; }
        public string Answer { get; set; }
    }
}
