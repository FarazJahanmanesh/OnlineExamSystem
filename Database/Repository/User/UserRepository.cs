using Application.Helpers;
using Domain.Contracts.Repository;
using Domain.Dtos.UserDtos;
using Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using XAct;

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
        public async Task UpdateUser(UpdateUserDetailDto dto)
        {
            var existingUser = await dbContext.Users.FirstOrDefaultAsync(i => i.Id == dto.Id);
            existingUser = dto.Adapt(existingUser);
            await SaveChange();
        }
        public async Task<GetUserDetailDto> GetUser(int id)
        {
            return (await dbContext.Users.ProjectToType<GetUserDetailDto>().AsNoTracking()
                .FirstOrDefaultAsync(i => i.Id == id))
                .Adapt<GetUserDetailDto>();
        }
        public async Task<List<GetUserDetailDto>> GetListOfUser(int skip, int take)
        {
            return await dbContext.Users.ProjectToType<GetUserDetailDto>()
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
            var  user = (await dbContext.Users.FirstOrDefaultAsync(i => i.Id == id))
                .Adapt<GetUserDetailDto>();

            user.IsActive = false;
            await SaveChange();
        }
        #endregion

        #region other methods
        public async Task<bool> Login(UserLoginDetailDto dto)
        {
            var user = await dbContext.Users.AsNoTracking()
                .Where(c=>c.IsActive==true)
                .FirstOrDefaultAsync(c => c.UserName == dto.UserName && c.Password.SHA1HashCode() == dto.Password);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task ChangeUserPassword(ChangeUserPasswordDetailDto dto)
        {
            var user = (await dbContext.Users.FirstOrDefaultAsync(i => i.Id == dto.Id))
                .Adapt<UpdateUserDetailDto>();

            user.Password = dto.Password.SHA1HashCode();
            await SaveChange();
        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
