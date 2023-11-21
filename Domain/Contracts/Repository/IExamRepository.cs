using Domain.Dtos.ExamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IExamRepository
    {
        public Task CreateExam(CreateExamDetailDto dto);
        public Task<bool> UpdateExam(UpdateExamDetailDto dto);
        public Task<bool> DeleteExam(DeleteExamDetailDto dto);
        public Task<List<ShowExamsDetailDto>> ShowExams();
        public Task<ShowExamsDetailDto> ShowExam();
    }
}
