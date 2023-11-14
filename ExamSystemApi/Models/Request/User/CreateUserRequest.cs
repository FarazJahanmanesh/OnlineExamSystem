using Domain.Enums.User;

namespace ExamSystemApi.Models.Request.User
{
    public class CreateUserRequest
    {
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public UserRoleEnum UserRole { get; set; }
    }
}
