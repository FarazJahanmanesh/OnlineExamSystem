using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Services
{
    public interface IUserServices
    {
        public Task UserExsist();
        public Task ChangePassword();
        public Task UpdateUser();
        public Task GetUser();
        public Task GetListOfUser();
        public Task CreateUser();
        public Task DeleteUser();
    }
}
