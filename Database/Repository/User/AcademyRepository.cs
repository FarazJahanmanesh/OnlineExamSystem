using Application.Helpers;
using Domain.Contracts.Repository;
using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using Mapster;
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
            await dbContext.Academies.AsNoTracking().ToListAsync();
        }
        public async Task GetAcademy(int id)
        {
            await dbContext.Academies.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task DeleteAcademy(int id)
        {
            await dbContext.Academies.FirstOrDefaultAsync(c=>c.Id==id);
            await SaveChange();
        }
        public async Task UpdateAcademy(UpdateAcademyDetailDto dto)
        {

        }
        public async Task AddAcademy()
        {

            await SaveChange();
        }
        public async Task<bool> AcademiesLogin(UserLoginDetailDto dto)
        {
            var user = await dbContext.Academies.AsNoTracking()
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
