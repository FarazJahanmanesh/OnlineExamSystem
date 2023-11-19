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
    }
}
