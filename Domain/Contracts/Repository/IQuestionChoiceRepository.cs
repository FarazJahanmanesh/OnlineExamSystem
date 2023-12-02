using Domain.Dtos.QuestionChoice;
using Domain.Dtos.QuestionChoiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IQuestionChoiceRepository
    {
        public Task<List<GetAllQuestionChoiceDetailDto>> GetAllQuestionChoice(int questionId);
        public Task<GetQuestionChoiceDetailDto> GetQuestionChoice(int id, int questionId);
        public Task AddQuestionChoice(AddQuestionChoiceDetailDto dto);
        public Task<bool> UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto);
        public Task<bool> DeleteQuestionChoice(int id);
    }
}
