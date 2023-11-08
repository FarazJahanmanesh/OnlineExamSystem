using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string? ChoiceId { get; set; }
        public string? AnswerContent { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
