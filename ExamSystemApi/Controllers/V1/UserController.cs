using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.UserDtos;
using ExamSystemApi.Models.Request;
using ExamSystemApi.Models.Response;
using Mapster;
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
        [HttpPost]
        [Route("UserLogin")]
        public async Task<IActionResult> UserLogin([FromBody] UserLoginRequest request)
        {
            var response = new ActionResponse<UserLoginResponse>();
            response.Data = new UserLoginResponse();
            try
            {
                var result = await services.Login(request.Adapt<UserLoginDetailDto>());
                if (result == false)
                {
                    response.Status = 400;
                    response.State = ResponseStateEnum.FAILED;
                    response.Message = "bad";
                }
                else
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                }
                response.Data.IsSuccess = result;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Status = 403;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "badd";
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword()
        {
            await services.ChangePassword();
            return Ok();
        }
        [HttpPost]
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
        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody]CreateUserRequest request)
        {
            await services.CreateUser(request.Adapt<CreateUserDetailDto>());
            return Ok();
        }
        [HttpPost]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await services.DeleteUser(id);
            return Ok();
        }
    }
}
