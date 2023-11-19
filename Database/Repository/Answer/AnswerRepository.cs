using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Answer
{
    public class AnswerRepository
    {
        private readonly SystemDbContext dbContext;
        public AnswerRepository(SystemDbContext dbContext)
        {
            this.dbContext= dbContext;
        }

    }
}
