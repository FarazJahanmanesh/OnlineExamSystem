using Domain.Dtos.QuestionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Services
{
    public interface IQuestionServices
    {
        public Task<GetQuestionsDetailDto> GetQuestion(int id);
        public Task<List<GetQuestionsDetailDto>> GetQuestions(int skip, int take);
        public Task<bool> DeleteQuestion(DeleteQuestionDetailDto dto);
        public Task<bool> UpdateQuestion(UpdateQuestionDetailDto dto);
        public Task AddQuestion(AddQuestionDetailDto dto);
    }
}
