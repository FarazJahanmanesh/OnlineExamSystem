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
        #endregion

        public async Task GetAllAcademies()
        {

        }
        public async Task GetAcademy()
        {

        }
        public async Task DeleteAcademy()
        {

        }
        public async Task AddAcademy()
        {

        }
        public async Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto)
        {
            return await _repository.AcademiesLogin(dto);
        }
        public async Task<bool> ChangeAcademyPassword(ChangeAcademyPasswordDetailDto dto)
        {
            return await _repository.ChangeAcademyPassword(dto);
        }
    }
}
