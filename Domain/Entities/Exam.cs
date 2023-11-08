using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public float FinallScore { get; set; }
        public int Price { get; set; }
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
        public List<User>? Users { get; set; }
    }
}
