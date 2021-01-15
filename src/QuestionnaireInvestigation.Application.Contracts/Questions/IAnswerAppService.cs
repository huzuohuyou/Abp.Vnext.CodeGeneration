using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuestionnaireInvestigation.Questions
{
    public interface IAnswerAppService :
        ICrudAppService< 
            AnswerDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateAnswerDto> 
    {
    }
}


