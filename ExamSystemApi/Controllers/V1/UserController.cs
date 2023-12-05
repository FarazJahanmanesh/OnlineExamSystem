using Domain.Common;
using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.UserDtos;
using ExamSystemApi.Models.Request;
using ExamSystemApi.Models.Request.User;
using ExamSystemApi.Models.Response;
using ExamSystemApi.Models.Response.User;
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
            try
            {
                var result = await services.Login(request.Adapt<UserLoginDetailDto>());
                if (result == false)
                {
                    response.Status = 400;
                    response.State = ResponseStateEnum.FAILED;
                    response.Message = StaticStrings.F_Login;
                }
                else
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Login;
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.Status = 403;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("ChangeUserPassword")]
        public async Task<IActionResult> ChangeUserPassword([FromBody] ChangeUserPasswordRequest request)
        {
            var response = new ActionResponse<ChangeUserPasswordResponse>();
            response.Data=new ChangeUserPasswordResponse();
            try
            {
                var result = await services.ChangeUserPassword(request.Adapt<ChangeUserPasswordDetailDto>());
                if (result)
                {
                    response.State=ResponseStateEnum.SUCCESS;
                    response.Status=200;
                    response.Message = StaticStrings.S_ChangePassword;
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
                response.Message = StaticStrings.F_ChangePassword;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request)
        {
            var response = new ActionResponse<UpdateUserResponse>();
            response.Data = new UpdateUserResponse();
            try
            {
                var newUser = await services.UpdateUser(request.Adapt<UpdateUserDetailDto>());
                if (newUser != null)
                {
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 200;
                    response.Message = StaticStrings.S_UpdateUser;
                    response.Data = newUser.Adapt<UpdateUserResponse>();
                    return Ok(response);
                }
                else
                {
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 404;
                    response.Message = StaticStrings.F_UpdateUser;
                    return Ok(response);
                }
            }
            catch(Exception ex) 
            {
                response.State = ResponseStateEnum.SUCCESS;
                response.Status = 503;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpGet]
        [Route("GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var response = new ActionResponse<GetUserResponse>();
            response.Data = new GetUserResponse();
            try
            {
                var user = await services.GetUser(id);
                if (user != null)
                {
                    response.Data = user.Adapt<GetUserResponse>();
                    response.Status=200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;

                    return Ok(response);
                }
                else
                {
                    response.Status = 404;
                    response.State = ResponseStateEnum.FAILED;
                    response.Message = StaticStrings.UserNotFound;
                    return Ok(response);
                }
            }
            catch(Exception ex)
            {
                response.Status = 503;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpGet]
        [Route("GetListOfUser")]
        public async Task<IActionResult> GetListOfUser(int skip,int take)
        {
            var response = new ActionResponse<List<GetUserResponse>>();
            response.Data = new List<GetUserResponse>();
            try
            {
                var users = await services.GetListOfUser(skip, take);
                if(users != null)
                {
                    response.Data = users.Adapt<List<GetUserResponse>>();
                    response.Status=200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;
                    return Ok(response);
                }
                else
                {
                    response.Status = 404;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.F_Calling;
                    return Ok(response);
                }
            }
            catch(Exception ex)
            {
                response.Status = 503;
                response.State = ResponseStateEnum.SUCCESS;
                response.Message =StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody]CreateUserRequest request)
        {
            var response = new ActionResponse<CreateUserResponse>();
            try
            {
                await services.CreateUser(request.Adapt<CreateUserDetailDto>());
                response.State= ResponseStateEnum.SUCCESS;
                response.Status = 200;
                response.Message = StaticStrings.S_CreateUser;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Status = 400;
                response.Message = StaticStrings.F_CreateUser;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var response = new ActionResponse<DeleteUserResponse>();
            try
            {
                var result = await services.DeleteUser(id);
                if (result)
                {
                    response.Message = StaticStrings.S_DeleteUser;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 200;
                    return Ok(response);
                }
                response.Message = StaticStrings.F_DeleteUser;
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            catch
            {
                response.Message = StaticStrings.ErrorInSystem;
                response.State=ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }
    }
}
