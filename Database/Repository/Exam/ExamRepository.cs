using Domain.Contracts.Repository;
using Domain.Entities;
using Domain.Enums.Exam;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Exam
{
    public class ExamRepository : IExamRepository
    {
        private readonly SystemDbContext dbContext;
        public ExamRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateExam()
        {
            await dbContext.Exams.AddAsync(new Domain.Entities.Exam
            {
                AcademyId = 1,
                IsActice = true,
                Price = 20000,
                FinallScore = 100,
            });
            await SaveChanges();
        }
        public async Task UpdateExam()
        {
            var exam = await dbContext.Exams.FirstOrDefaultAsync();
            if (exam != null)
            {
                //exam = dto.Adapt(exam);
                //await SaveChanges();
            }
        }
        public async Task DeleteExam()
        {
            var exam = await dbContext.Exams.FirstOrDefaultAsync();
            if (exam != null)
            {
                //exam.IsActive = false;
                //await SaveChanges();
            }
        }
        public async Task ShowExams()
        {
            var exams = await dbContext.Exams.AsNoTracking().ProjectToType<object>().Skip(0).Take(5).ToListAsync();
            //return exams; 
        }
        public async Task ShowExam()
        {
            var exam = await dbContext.Exams.AsNoTracking().ProjectToType<object>().FirstOrDefaultAsync();
            //return exam;
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
