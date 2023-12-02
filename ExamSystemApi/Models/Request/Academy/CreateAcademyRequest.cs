namespace ExamSystemApi.Models.Request.Academy
{
    public class CreateAcademyRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public string? Email { get; set; }
    }
}
