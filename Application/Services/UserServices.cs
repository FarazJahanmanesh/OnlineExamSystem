using Domain.Contracts.Repository;
using Domain.Contracts.Services;
using Domain.Dtos.UserDtos;
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
        public async Task CreateUser(CreateUserDetailDto dto)
        {
            await repository.CreateUser(dto);
        }


        public async Task<List<GetUserDetailDto>> GetListOfUser(int skip, int take)
        {
            return await repository.GetListOfUser(skip,take);
        }

        public async Task<GetUserDetailDto> GetUser(int id)
        {
            return await repository.GetUser(id);
        }

        public async Task<GetUserDetailDto> UpdateUser(UpdateUserDetailDto dto)
        {
            return await repository.UpdateUser(dto);
        }
        public async Task<bool> DeleteUser(int id)
        {
            return await repository.DeleteUser(id);
        }
        #endregion

        #region other methods


        public async Task<bool> Login(UserLoginDetailDto dto)
        {
            return await repository.Login(dto);
        }

        public async Task<bool> ChangeUserPassword(ChangeUserPasswordDetailDto dto)
        {
            return await repository.ChangeUserPassword(dto);
        }

        #endregion
    }
}