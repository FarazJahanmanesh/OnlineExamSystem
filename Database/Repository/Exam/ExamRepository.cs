using Domain.Contracts.Repository;
using Domain.Dtos.ExamDtos;
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
        public async Task CreateExam(CreateExamDetailDto dto)
        {
            await dbContext.Exams.AddAsync(dto.Adapt<Domain.Entities.Exam>());
            await SaveChanges();
        }
        public async Task<bool> UpdateExam(UpdateExamDetailDto dto)
        {
            var exam = await dbContext.Exams.FirstOrDefaultAsync(c=>c.IsActice==true);
            if (exam != null)
            {
                exam = dto.Adapt(exam);
                await SaveChanges();
                return true;
            }
            return false;
        }
        public async Task<bool> DeleteExam(DeleteExamDetailDto dto)
        {
            var exam = await dbContext.Exams.FirstOrDefaultAsync(c=>c.IsActice==true&&c.Id==dto.Id);
            if (exam != null)
            {
                exam.IsActice = false;
                await SaveChanges();
                return true;
            }
            return false;
        }
        public async Task<List<ShowExamsDetailDto>> ShowExams(int skip , int take)
        {
            return await dbContext.Exams.AsNoTracking()
                .ProjectToType<ShowExamsDetailDto>()
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }
        public async Task<ShowExamsDetailDto> ShowExam(int id)
        {
            return await dbContext.Exams.AsNoTracking()
                .ProjectToType<ShowExamsDetailDto>()
                .FirstOrDefaultAsync(i=>i.IsActice==true&&i.Id==id);
        }
        private async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
