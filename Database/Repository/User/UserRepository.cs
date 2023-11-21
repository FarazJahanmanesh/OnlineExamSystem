using Application.Helpers;
using Domain.Contracts.Repository;
using Domain.Dtos.AcademyDtos;
using Domain.Dtos.UserDtos;
using Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using XAct;
using XAct.Users;

namespace Database.Repository.User
{
    public class UserRepository : IUserRepository
    {
        #region ctor
        private readonly SystemDbContext dbContext;
        public UserRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region crud
        public async Task<GetUserDetailDto> UpdateUser(UpdateUserDetailDto dto)
        {
            var existingUser = await dbContext.Users
                .FirstOrDefaultAsync(i => i.IsActive==true && i.Id == dto.Id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser = dto.Adapt(existingUser);
            await SaveChange();
            return existingUser.Adapt<GetUserDetailDto>();
        }
        public async Task<GetUserDetailDto> GetUser(int id)
        {
            return await dbContext.Users.AsNoTracking()
                .ProjectToType<GetUserDetailDto>()
                .FirstOrDefaultAsync(i => i.IsActive==true&&i.Id == id);
        }
        public async Task<List<GetUserDetailDto>> GetListOfUser(int skip, int take)
        {
            return await dbContext.Users.ProjectToType<GetUserDetailDto>()
                .Where(c=>c.IsActive==true)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }
        public async Task CreateUser(CreateUserDetailDto dto)
        {
            await dbContext.Users.AddAsync(dto.Adapt<Domain.Entities.User>());
            await SaveChange();
        }
        public async Task DeleteUser(int id)
        {
            var  user = await dbContext.Users
                .FirstOrDefaultAsync(i => i.IsActive==true && i.Id == id);
            if(user != null)
            {
                user.IsActive = false;
            }
            await SaveChange();
        }
        #endregion

        #region other methods
        public async Task<bool> Login(UserLoginDetailDto dto)
        {
            var user = await dbContext.Users.AsNoTracking()
                .ProjectToType<UserLoginDetailDto>()
                .FirstOrDefaultAsync(c => c.IsActive == true && c.UserName == dto.UserName && c.Password == dto.Password);
            if (user == null)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> ChangeUserPassword(ChangeUserPasswordDetailDto dto)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(i => i.IsActive==true&&i.Id == dto.Id);
            if( user != null )
            {
                user = dto.Adapt(user);
                await SaveChange();
                return true;
            }
            return false;
        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}

