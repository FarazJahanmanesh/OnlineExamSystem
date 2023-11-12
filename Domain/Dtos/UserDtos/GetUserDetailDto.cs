using Domain.Entities;
using Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.UserDtos
{
    public class GetUserDetailDto
    {
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public UserRoleEnum UserRole { get; set; }
        public List<Exam>? Exams { get; set; }
        public List<Academy> Academies { get; set; }
    }
}
