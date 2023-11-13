using Application.Helpers;
using Domain.Contracts.Repository;
using Domain.Dtos.UserDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.User
{
    public class AcademyRepository: IAcademyRepository
    {
        #region ctor
        private readonly SystemDbContext dbContext;
        public AcademyRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
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
        public async Task<bool> AcademiesLogin(UserLoginDetailDto dto)
        {
            var user = dbContext.Academies.AsNoTracking()
                .Where(c => c.IsActive == true)
                .FirstOrDefaultAsync(c => c.UserName == dto.UserName && c.Password == dto.Password);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task ChangeAcademyPassword(string password, int id)
        {
            await SaveChange();
        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
