namespace ExamSystemApi.Models.Request.QuestionChoice
{
    public class AddQuestionChoiceRequest
    {
        public string Content { get; set; }
        public bool IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
