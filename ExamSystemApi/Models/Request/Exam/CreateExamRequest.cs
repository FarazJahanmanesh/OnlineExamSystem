namespace ExamSystemApi.Models.Request.Exam
{
    public class CreateExamRequest
    {
        public float FinallScore { get; set; }
        public int Price { get; set; }
        public int AcademyId { get; set; }
    }
}
