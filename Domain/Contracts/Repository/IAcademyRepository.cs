using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IAcademyRepository
    {
        public  Task GetAllAcademies();
        public Task GetAcademy(int id);
        public Task DeleteAcademy(int id);
        public Task AddAcademy();
        public Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto);
        public Task<bool> ChangeAcademyPassword(ChangeAcademyPasswordDetailDto dto);
    }
}
