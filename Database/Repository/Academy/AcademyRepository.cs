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
        public async Task<List<GetAcademyDetailDto>> GetAllAcademies(int skip,int take)
        {
            return await dbContext.Academies.AsNoTracking()
                .ProjectToType<GetAcademyDetailDto>()
                .Where(i=>i.IsActive==true)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }
        public async Task<GetAcademyDetailDto> GetAcademy(int id)
        {
            return await dbContext.Academies.AsNoTracking()
                .ProjectToType<GetAcademyDetailDto>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<bool> DeleteAcademy(int id)
        {
            var academy = await dbContext.Academies.FirstOrDefaultAsync(c => c.IsActive==true&&c.Id == id);
            if(academy != null)
            {
                academy.IsActive = false;
                await SaveChange();
                return true;
            }
            return false;
        }
        public async Task<bool> UpdateAcademy(UpdateAcademyDetailDto dto)
        {
            var academy = await dbContext.Academies.FirstOrDefaultAsync(c => c.IsActive == true );
            if (academy != null)
            {
                academy = dto.Adapt(academy);
                await SaveChange();
                return true;
            }
            return false;
        }
        public async Task<bool> AddAcademy(CreateAcademyDetailDto dto)
        {
            if (await AcademyExist(dto.UserName))
            {
                await dbContext.Academies.AddAsync(dto.Adapt<Domain.Entities.Academy>());
                await SaveChange();
                return true;
            }
            return false;
        }
        public async Task<bool> AcademiesLogin(AcademiesLoginDetailDto dto)
        {
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
                academy = dto.Adapt(academy);
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
