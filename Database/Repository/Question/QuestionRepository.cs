using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Question
{
    public class QuestionRepository
    {
        private readonly SystemDbContext dbContext;
        public QuestionRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task GetQuestion()
        {

        }
        public async Task GetQuestions()
        {

        }
        public async Task DeleteQuestion()
        {

        }
        public async Task UpdateQuestion()
        {

        }
        public async Task AddQuestion()
        {
            await dbContext.Questions.AddAsync()
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
