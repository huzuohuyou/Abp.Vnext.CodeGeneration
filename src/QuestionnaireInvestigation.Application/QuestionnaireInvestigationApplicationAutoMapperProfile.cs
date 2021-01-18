using AutoMapper;
using QuestionnaireInvestigation.Questions;

namespace QuestionnaireInvestigation
{
    public class QuestionnaireInvestigationApplicationAutoMapperProfile : Profile
    {
        public QuestionnaireInvestigationApplicationAutoMapperProfile()
        {
            CreateMap<Question, QuestionDto>();
            CreateMap<CreateUpdateQuestionDto, Question>();
            CreateMap<Answer, AnswerDto>();
            CreateMap<CreateUpdateAnswerDto, Answer>();
 

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}








