using Domain.Contracts.Repository;
using Domain.Dtos.AnswerDtos;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace Database.Repository.Answer
{
    public class AnswerRepository: IAnswerRepository
    {
        private readonly SystemDbContext dbContext;
        public AnswerRepository(SystemDbContext dbContext)
        {
            this.dbContext= dbContext;
        }
        public async Task<List<GetAllAnswerDetailDto>> GetAllAnswer()
        {
            return await dbContext.Answers.AsNoTracking()
                .ProjectToType<GetAllAnswerDetailDto>()
                .ToListAsync();
        }
        public async Task<GetAllAnswerDetailDto> GetAnswer()
        {
            return await dbContext.Answers.AsNoTracking()
                .ProjectToType<GetAllAnswerDetailDto>()
                .FirstOrDefaultAsync();
        }
        public async Task UpdateAnswer()
        {

        }
        public async Task DeleteAnswer()
        {

        }
        public async Task<bool> ChangeAnswer(ChangeAnswerDetailDto dto)
        {
            var answer = await dbContext.Answers.FirstOrDefaultAsync(c => c.Id == dto.Id);
            if (answer != null)
            {
                answer = dto.Adapt(answer);
                await SaveChanges();
                return true;
            }
            return false;
        }
        public async Task AddAnswer(AddAnswerDetailDto dto)
        {
            await dbContext.Answers.AddAsync(dto.Adapt<Domain.Entities.Answer>());
            await SaveChanges();
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
