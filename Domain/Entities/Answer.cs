using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Answer : BaseEntity
    {
        public int? QuestionChoiceId { get; set; }
        public string? AnswerContent { get; set; }
        public bool IsTrue { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
