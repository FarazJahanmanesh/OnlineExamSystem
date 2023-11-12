using Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.UserDtos
{
    public class CreateUserDetailDto
    {
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
        public UserRoleEnum UserRole { get; set; }
    }
}
