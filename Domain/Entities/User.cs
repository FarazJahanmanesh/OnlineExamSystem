﻿using Domain.Common;
using Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public UserRoleEnum UserRole { get; set; }
        public List<Exam>? Exams { get; set; }
        public List<Academy> Academies { get; set; }
    }
}
