namespace ExamSystemApi.Models.Request.User
{
    public class ChangeUserPasswordRequest
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
