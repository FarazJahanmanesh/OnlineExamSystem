using Domain.Enums.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public ExamTypeEnum ExamType { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
