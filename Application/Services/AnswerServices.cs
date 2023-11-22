using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.AnswerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AnswerServices: IAnswerServices
    {
        private readonly IAnswerRepository repository;
        public AnswerServices(IAnswerRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddAnswer(AddAnswerDetailDto dto)
        {
            await repository.AddAnswer(dto);
        }

        public async Task DeleteAnswer()
        {
            await repository.DeleteAnswer();
        }

        public async Task<List<GetAllAnswerDetailDto>> GetAllAnswer()
        {
            return await repository.GetAllAnswer();
        }

        public async Task<GetAllAnswerDetailDto> GetAnswer()
        {
            return await repository.GetAnswer();
        }

        public async Task UpdateAnswer()
        {
            await repository.UpdateAnswer();
        }
    }
}
