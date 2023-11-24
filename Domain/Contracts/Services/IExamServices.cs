using Domain.Dtos.ExamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Services
{
    public interface IExamServices
    {
        public Task CreateExam(CreateExamDetailDto dto);
        public Task<bool> UpdateExam(UpdateExamDetailDto dto);
        public Task<bool> DeleteExam(DeleteExamDetailDto dto);
        public Task<List<ShowExamsDetailDto>> ShowExams(int skip, int take);
        public Task<ShowExamsDetailDto> ShowExam(int id);
    }
}
