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
        public Task<GetUserDetailDto> GetUser(int id);
        public Task<List<GetUserDetailDto>> GetListOfUser(int skip, int take);
        public Task CreateUser(CreateUserDetailDto dto);
        public Task DeleteUser();
    }
}
