namespace ExamSystemApi.Models.Request.Academy
{
    public class AcademiesLoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
