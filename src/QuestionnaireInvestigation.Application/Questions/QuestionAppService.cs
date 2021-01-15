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
    public class QuestionAppService :
        CrudAppService<
            Question,
            QuestionDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateQuestionDto>,
        IQuestionAppService
    {
        public QuestionAppService(IRepository<Question, Guid> repository)
            : base(repository)
        {

        }
    }
}
