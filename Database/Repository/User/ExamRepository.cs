using Domain.Contracts.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.User
{
    public class ExamRepository: IExamRepository
    {
        private readonly SystemDbContext dbContext;
        public ExamRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
