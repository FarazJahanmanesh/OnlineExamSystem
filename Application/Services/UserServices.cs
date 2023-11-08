using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserServices : IUserServices
    {
        #region ctor 
        private readonly IUserRepository repository;
        public UserServices(IUserRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region crud
        public async Task CreateUser()
        {
            await repository.CreateUser();
        }

        public async Task DeleteUser()
        {
            await repository.DeleteUser();
        }

        public async Task GetListOfUser()
        {
            await repository.GetListOfUser();
        }

        public async Task GetUser()
        {
            await repository.GetUser();
        }

        public async Task UpdateUser()
        {
            await repository.UpdateUser();
        }

        #endregion

        #region other methods
        public async Task ChangePassword()
        {
            await repository.ChangePassword();
        }

        public async Task UserExsist()
        {
            await repository.UserExsist(3);
        }
        #endregion
    }
}
