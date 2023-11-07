using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository.User
{
    public class UserRepository
    {
        private readonly SystemDbContext dbContext;
        public UserRepository(SystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task UserExsist()
        {

        }
        public async Task ChangePassword()
        {

        }
        public async Task UpdateUser()
        {
            
        }
        public async Task GetUser()
        {

        }
        public async Task GetListOfUser()
        {

        }
        public async Task CreateUser()
        {

        }
        public async Task DeleteUser()
        {

        }
        private async Task SaveChange()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
