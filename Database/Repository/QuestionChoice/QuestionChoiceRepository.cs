using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.QuestionChoice
{
    public class QuestionChoiceRepository
    {
        private readonly SystemDbContext dbContext;
        public QuestionChoiceRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
