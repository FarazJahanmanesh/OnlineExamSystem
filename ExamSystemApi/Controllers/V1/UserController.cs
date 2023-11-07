using Domain.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices services; 
        public UserController(IUserServices services)
        {
            this.services = services;
        }
        [HttpGet]
        [Route("UserExsist")]
        public async Task<IActionResult> UserExsist()
        {
            await services.UserExsist();
            return Ok();
        }
        [HttpGet]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword()
        {
            await services.ChangePassword();
            return Ok();
        }
        [HttpGet]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser()
        {
            await services.UpdateUser();
            return Ok();
        }
        [HttpGet]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            await services.GetUser();
            return Ok();
        }
        [HttpGet]
        [Route("GetListOfUser")]
        public async Task<IActionResult> GetListOfUser()
        {
            await services.GetListOfUser();
            return Ok();
        }
        [HttpGet]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser()
        {
            await services.CreateUser();
            return Ok();
        }
        [HttpGet]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser()
        {
            await services.DeleteUser();
            return Ok();
        }
    }
}
