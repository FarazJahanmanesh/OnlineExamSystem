namespace ExamSystemApi.Models.Request.Exam
{
    public class UpdateExamRequest
    {
        public float FinallScore { get; set; }
        public int Price { get; set; }
        public bool IsActice { get; set; }
    }
}
