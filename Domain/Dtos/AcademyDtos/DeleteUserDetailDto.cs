using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.AcademyDtos
{
    public class DeleteUserDetailDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
