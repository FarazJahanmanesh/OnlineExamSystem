using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.QuestionChoiceDtos
{
    public class GetQuestionChoiceDetailDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
