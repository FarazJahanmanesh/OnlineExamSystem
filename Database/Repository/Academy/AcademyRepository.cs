using Domain.Contracts.Repository;
using Domain.Dtos.AcademyDtos;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.Academy
{
    public class AcademyRepository : IAcademyRepository
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
            await dbContext.Academies.FirstOrDefaultAsync(c => c.Id == id);
            await SaveChange();
        }
        public async Task UpdateAcademy(UpdateAcademyDetailDto dto)
        {
            var academy = await dbContext.Academies.FirstOrDefaultAsync(c => c.IsActive == true );
            if (academy != null)
            {
            }
            await SaveChange();
        }
        public async Task AddAcademy()
        {

            await SaveChange();
        }
        public async Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto)
        {
            await AcademyExist("jahan");
            var user = await dbContext.Academies.AsNoTracking()
                .ProjectToType<AcademiesLoginDetailDto>()
                .FirstOrDefaultAsync(c => c.IsActive==true && c.UserName == dto.UserName && c.Password == dto.Password);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<bool> ChangeAcademyPassword(ChangeAcademyPasswordDetailDto dto)
        {
            var academy = await dbContext.Academies.FirstOrDefaultAsync(c => c.IsActive == true && c.Id == dto.Id && c.Password == dto.Password);
            if (academy != null)
            {
                academy.Password = dto.Password;
                await SaveChange();
                return true;
            }
            return false;
        }
        private async Task<bool> AcademyExist(string username)
        {
            AcademyExistDetailDto? user = await dbContext.Academies.AsNoTracking()
                .ProjectToType<AcademyExistDetailDto>()
                .FirstOrDefaultAsync(c => c.UserName == username);
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
