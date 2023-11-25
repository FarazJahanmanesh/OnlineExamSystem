using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IAcademyRepository
    {
        public Task<List<GetAcademyDetailDto>> GetAllAcademies(int skip, int take);
        public Task<GetAcademyDetailDto> GetAcademy(int id);
        public Task<bool> DeleteAcademy(int id);
        public Task<bool> UpdateAcademy(UpdateAcademyDetailDto dto);
        public Task<bool> AddAcademy(CreateAcademyDetailDto dto);
        public Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto);
        public Task<bool> ChangeAcademyPassword(ChangeAcademyPasswordDetailDto dto);
    }
}
