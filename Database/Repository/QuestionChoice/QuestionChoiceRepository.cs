using Domain.Contracts.Repository;
using Domain.Dtos.QuestionChoice;
using Domain.Dtos.QuestionChoiceDtos;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.QuestionChoice
{
    public class QuestionChoiceRepository: IQuestionChoiceRepository
    {
        private readonly SystemDbContext dbContext; 
        public QuestionChoiceRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<GetQuestionChoiceDetailDto> GetQuestionChoice(int id, int questionId)
        {
            return await dbContext.QuestionChoices.ProjectToType<GetQuestionChoiceDetailDto>()
                .FirstOrDefaultAsync(c=>c.Id==id && c.QuestionId==questionId);
        }
        public async Task AddQuestionChoice(AddQuestionChoiceDetailDto dto)
        {
            await dbContext.QuestionChoices.AddAsync(dto.Adapt<Domain.Entities.QuestionChoice>());
        }
        public async Task UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto)
        {
            var questionChoice = await dbContext.QuestionChoices.FirstOrDefaultAsync(c=>c.Id==dto.Id);
            questionChoice = dto.Adapt(questionChoice);
            await SaveChanges();
        }
        public async Task DeleteQuestionChoice(int id)
        {
            var questionChoice = await dbContext.QuestionChoices.FirstOrDefaultAsync(c => c.Id == id);
            dbContext.QuestionChoices.Remove(questionChoice);
            await SaveChanges();
        }
        public async Task<List<GetAllQuestionChoiceDetailDto>> GetAllQuestionChoice(int questionId)
        {
            return await dbContext.QuestionChoices.ProjectToType<GetAllQuestionChoiceDetailDto>()
                .Where(c => c.QuestionId == questionId)
                .Skip(0)
                .Take(4)
                .ToListAsync();
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
