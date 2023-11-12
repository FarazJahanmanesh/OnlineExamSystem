using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Academy: BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
        public List<User>? Users { get; set; }
        public List<Exam>? Exams { get; set; }
    }
}
