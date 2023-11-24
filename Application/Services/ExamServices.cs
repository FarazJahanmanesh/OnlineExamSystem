using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.ExamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ExamServices: IExamServices
    {
        private readonly IExamRepository repository;
        public ExamServices(IExamRepository repository)
        {
            this.repository = repository;
        }

        public async Task CreateExam(CreateExamDetailDto dto)
        {
            await repository.CreateExam(dto);
        }

        public async Task<bool> DeleteExam(DeleteExamDetailDto dto)
        {
            return await repository.DeleteExam(dto);
        }

        public async Task<ShowExamsDetailDto> ShowExam(int id)
        {
            return await repository.ShowExam(id);
        }

        public async Task<List<ShowExamsDetailDto>> ShowExams(int skip, int take)
        {
            return await repository.ShowExams(skip, take);
        }

        public async Task<bool> UpdateExam(UpdateExamDetailDto dto)
        {
            return await repository.UpdateExam(dto);
        }
    }
}
