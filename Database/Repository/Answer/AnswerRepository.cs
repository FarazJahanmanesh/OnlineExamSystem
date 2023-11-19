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
    public class AnswerRepository
    {
        private readonly SystemDbContext dbContext;
        public AnswerRepository(SystemDbContext dbContext)
        {
            this.dbContext= dbContext;
        }
        public async Task GetAllAnswer()
        {
            await dbContext.Answers.AsNoTracking().ProjectToType<>().ToListAsync();
        }
        public async Task GetAnswer()
        {
            await dbContext.Answers.AsNoTracking().ProjectToType<>().FirstOrDefaultAsync();
        }
        public async Task UpdateAnswer()
        {

        }
        public async Task DeleteAnswer()
        {

        }
        public async Task AddAnswer()
        {

        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
