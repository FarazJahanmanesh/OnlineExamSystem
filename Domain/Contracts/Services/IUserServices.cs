using Domain.Dtos.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Services
{
    public interface IUserServices
    {
        public Task<bool> Login(UserLoginDetailDto dto);
        public Task ChangeUserPassword(ChangeUserPasswordDetailDto dto);
        public Task<GetUserDetailDto> UpdateUser(UpdateUserDetailDto dto);
        public Task<GetUserDetailDto> GetUser(int id);
        public Task<List<GetUserDetailDto>> GetListOfUser(int skip, int take);
        public Task CreateUser(CreateUserDetailDto dto);
        public Task DeleteUser(int id);
    }
}
