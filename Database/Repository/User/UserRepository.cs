using Domain.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository.User
{
    public class UserRepository: IUserRepository
    {
        #region ctor
        private readonly SystemDbContext dbContext;
        public UserRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        #region crud
        public async Task UpdateUser()
        {

        }
        public async Task GetUser()
        {
            var user = await dbContext.Users.AsNoTracking().FirstOrDefaultAsync();
        }
        public async Task GetListOfUser()
        {
            var user = await dbContext.Users.AsNoTracking().Skip(0).Take(10).ToListAsync();
        }
        public async Task CreateUser()
        {

        }
        public async Task DeleteUser()
        {

        }
        #endregion

        #region other methods

        public async Task UserExsist(int id)//username 
        {
            var user = dbContext.Users.AsNoTracking().FirstOrDefaultAsync();
            if (user == null)
            {
                //return false;
            }
            else
            {
                //return true;
            }
        }
        public async Task ChangePassword()
        {

        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
