using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuestionnaireInvestigation.Questions
{
    public interface IQuestionAppService :
        ICrudAppService< 
            QuestionDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateQuestionDto> 
    {
    }
}


