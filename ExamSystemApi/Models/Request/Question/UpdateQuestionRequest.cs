namespace ExamSystemApi.Models.Request.Question
{
    public class UpdateQuestionRequest
    {
        public int id { get; set; }
        public float Score { get; set; }
        public string Content { get; set; }
    }
}
