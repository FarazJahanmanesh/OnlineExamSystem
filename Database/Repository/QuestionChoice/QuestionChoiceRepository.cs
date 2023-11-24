using Domain.Contracts.Repository;
using Domain.Dtos.QuestionChoice;
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
        public async Task<List<GetAllQuestionChoiceDetailDto>> GetAllQuestionChoice(int questionId)
        {
            return await dbContext.QuestionChoices.AsNoTracking()
                .ProjectToType<GetAllQuestionChoiceDetailDto>()
                .Where(i=>i.QuestionId == questionId)
                .ToListAsync();
        }
        public async Task GetQuestionChoice()
        {

        }
        public async Task AddQuestionChoice(AddQuestionChoiceDetailDto dto)
        {
            await dbContext.QuestionChoices.AddAsync(dto.Adapt<Domain.Entities.QuestionChoice>());
        }
        public async Task UpdateQuestionChoice(UpdateQuestionChoiceDetailDto dto)
        {
            await dbContext.QuestionChoices.FirstOrDefaultAsync(c=>c.Id==dto.Id);
            await SaveChanges();
        }
        public async Task<bool> DeleteQuestionChoice(int id)
        {
            await
            await SaveChanges();
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
