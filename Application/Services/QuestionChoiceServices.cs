using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.QuestionChoice;
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

        public async Task DeleteQuestionChoice()
        {
            await repository.DeleteQuestionChoice();
        }

        public async Task GetAllQuestionChoice()
        {
            await repository.GetAllQuestionChoice();
        }

        public async Task GetQuestionChoice()
        {
            await repository.GetQuestionChoice();
        }

        public async Task UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto)
        {
            await repository.UpdateQuestionChoice(dto);
        }
    }
}
