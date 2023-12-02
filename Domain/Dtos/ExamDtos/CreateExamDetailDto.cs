using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.ExamDtos
{
    public class CreateExamDetailDto
    {
        public float FinallScore { get; set; }
        public int Price { get; set; }
        public bool IsActice { get; set; } = true;
        public int AcademyId { get; set; }
    }
}
