using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AcademyServices : IAcademyServices
    {
        #region ctor
        private readonly IAcademyRepository _repository;
        public AcademyServices(IAcademyRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto)
        {
             return await _repository.AcademiesLogin(dto);
        }

        public async  Task<bool> AddAcademy(CreateAcademyDetailDto dto)
        {
              return await _repository.AddAcademy(dto);
        }

        public async Task<bool> ChangeAcademyPassword(ChangeAcademyPasswordDetailDto dto)
        {
            return await ChangeAcademyPassword(dto);
        }

        public async Task<bool> DeleteAcademy(int id)
        {
            return await _repository.DeleteAcademy(id);
        }

        public async Task<GetAcademyDetailDto> GetAcademy(int id)
        {
            return await _repository.GetAcademy(id);
        }

        public async Task<List<GetAcademyDetailDto>> GetAllAcademies()
        {
            return await _repository.GetAllAcademies();
        }

        public async Task<bool> UpdateAcademy(UpdateAcademyDetailDto dto)
        {
            return await _repository.UpdateAcademy(dto);
        }
        #endregion

    }
}
