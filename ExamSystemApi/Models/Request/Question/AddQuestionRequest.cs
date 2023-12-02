using Domain.Enums.Exam;

namespace ExamSystemApi.Models.Request.Question
{
    public class AddQuestionRequest
    {
        public float Score { get; set; }
        public string Content { get; set; }
        public ExamTypeEnum ExamType { get; set; }
        public int ExamId { get; set; }
    }
}
