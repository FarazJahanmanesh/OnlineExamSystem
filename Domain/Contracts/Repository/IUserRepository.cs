using Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Repository
{
    public interface IUserRepository
    {
        public Task<bool> Login(UserLoginDetailDto dto);
        public Task UserExsist(int id);
        public Task ChangePassword();
        public Task UpdateUser();
        public Task GetUser();
        public Task GetListOfUser();
        public Task CreateUser();
        public Task DeleteUser();
    }
}
