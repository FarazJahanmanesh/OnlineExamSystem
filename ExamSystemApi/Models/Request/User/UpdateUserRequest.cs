namespace ExamSystemApi.Models.Request.User
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
    }
}
