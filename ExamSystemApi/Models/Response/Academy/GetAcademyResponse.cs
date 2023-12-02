namespace ExamSystemApi.Models.Response.Academy
{
    public class GetAcademyResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string? Email { get; set; }
    }
}
