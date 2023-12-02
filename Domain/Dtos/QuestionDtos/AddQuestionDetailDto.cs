using Domain.Enums.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.QuestionDtos
{
    public class AddQuestionDetailDto
    {
        public float Score { get; set; }
        public string Content { get; set; }
        public ExamTypeEnum ExamType { get; set; }
        public int ExamId { get; set; }
    }
}
