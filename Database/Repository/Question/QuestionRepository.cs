using Domain.Contracts.Repository;
using Domain.Dtos.QuestionDtos;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace Database.Repository.Question
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SystemDbContext dbContext;
        public QuestionRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<GetQuestionsDetailDto> GetQuestion(int id)
        {
            return await dbContext.Questions.AsNoTracking()
                .ProjectToType<GetQuestionsDetailDto>()
                .FirstOrDefaultAsync(c => c.IsActive == true && c.Id == id);
        }
        public async Task<List<GetQuestionsDetailDto>> GetQuestions(int skip, int take)
        {
            return await dbContext.Questions.AsNoTracking()
                .ProjectToType<GetQuestionsDetailDto>()
                .Where(c => c.IsActive == true)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }
        public async Task<bool> DeleteQuestion(DeleteQuestionDetailDto dto)
        {
            var question = await dbContext.Questions.FirstOrDefaultAsync(c => c.Id == dto.Id);
            if (question != null)
            {
                question = dto.Adapt(question);
                await SaveChanges();
                return true;
            }
            return false;
        }
        public async Task<bool> UpdateQuestion(UpdateQuestionDetailDto dto)
        {
            var question = await dbContext.Questions.FirstOrDefaultAsync(c=>c.Id==dto.Id);
            if (question != null)
            {
                question = dto.Adapt(question);
                await SaveChanges();
                return true;
            }
            return false;
        }
        public async Task AddQuestion(AddQuestionDetailDto dto)
        {
            await dbContext.Questions.AddAsync(dto.Adapt<Domain.Entities.Question>());
            await SaveChanges();
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
