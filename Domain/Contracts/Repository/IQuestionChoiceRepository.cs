using Domain.Dtos.QuestionChoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IQuestionChoiceRepository
    {
        public Task<GetAllQuestionChoiceDetailDto> GetAllQuestionChoice(int questionId);
        public Task GetQuestionChoice();
        public Task AddQuestionChoice(AddQuestionChoiceDetailDto dto);
        public Task UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto);
        public Task DeleteQuestionChoice();
    }
}
