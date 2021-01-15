using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace QuestionnaireInvestigation.Questions
{
    public class AnswerAppService :
        CrudAppService<
            Answer,
            AnswerDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateAnswerDto>,
        IAnswerAppService
    {
        public AnswerAppService(IRepository<Answer, Guid> repository)
            : base(repository)
        {

        }
    }
}
