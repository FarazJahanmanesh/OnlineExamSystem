using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.QuestionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class QuestionServices: IQuestionServices
    {
        private readonly IQuestionRepository repository;
        public QuestionServices(IQuestionRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddQuestion(AddQuestionDetailDto dto)
        {
            await repository.AddQuestion(dto);
        }

        public async Task<bool> DeleteQuestion(DeleteQuestionDetailDto dto)
        {
            return await repository.DeleteQuestion(dto);
        }

        public async Task<GetQuestionsDetailDto> GetQuestion(int id)
        {
            return await repository.GetQuestion(id);
        }

        public async Task<List<GetQuestionsDetailDto>> GetQuestions(int skip, int take)
        {
            return await repository.GetQuestions(skip, take);
        }

        public async Task<bool> UpdateQuestion(UpdateQuestionDetailDto dto)
        {
            return await repository.UpdateQuestion(dto);
        }
    }
}
