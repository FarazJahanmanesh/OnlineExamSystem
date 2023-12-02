using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.QuestionChoice;
using Domain.Dtos.QuestionChoiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class QuestionChoiceServices : IQuestionChoiceServices
    {
        private readonly IQuestionChoiceRepository repository;
        public QuestionChoiceServices(IQuestionChoiceRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddQuestionChoice(AddQuestionChoiceDetailDto dto)
        {
            await repository.AddQuestionChoice(dto);
        }

        public async Task<bool> DeleteQuestionChoice(int id)
        {
            return await repository.DeleteQuestionChoice(id);
        }

        public async Task<List<GetAllQuestionChoiceDetailDto>> GetAllQuestionChoice(int id)
        {
            return await repository.GetAllQuestionChoice(id);
        }

        public async Task<GetQuestionChoiceDetailDto> GetQuestionChoice(int id, int questionId)
        {
            return await repository.GetQuestionChoice(id,questionId);
        }

        public async Task<bool> UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto)
        {
            return await repository.UpdateQuestionChoice(dto);
        }
    }
}
