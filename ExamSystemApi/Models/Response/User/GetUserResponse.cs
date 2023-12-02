using Domain.Enums.User;

namespace ExamSystemApi.Models.Response.User
{
    public class GetUserResponse
    {
        public string UserName { get; set; }//phone
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public UserRoleEnum UserRole { get; set; }
    }
}
