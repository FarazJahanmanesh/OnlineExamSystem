using Domain.Dtos.AnswerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Services
{
    public interface IAnswerServices
    {
        public Task<List<GetAllAnswerDetailDto>> GetAllAnswer();
        public Task<GetAllAnswerDetailDto> GetAnswer();
        public Task UpdateAnswer();
        public Task DeleteAnswer();
        public Task AddAnswer(AddAnswerDetailDto dto);
    }
}
