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
                    response.Message = "bad";
                }
                else
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                }
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
                    response.Message = "success";
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
                response.Message = "bad";
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
                response.Message = "bad";
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
                    response.Message = "ok";
                    response.Data = newUser.Adapt<UpdateUserResponse>();
                    return Ok(response);
                }
                else
                {
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 404;
                    response.Message = "bad";
                    return Ok(response);
                }
            }
            catch(Exception ex) 
            {
                response.State = ResponseStateEnum.SUCCESS;
                response.Status = 503;
                response.Message = "bad";
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
                    response.Message = "ok";

                    return Ok(response);
                }
                else
                {
                    response.Status = 404;
                    response.State = ResponseStateEnum.FAILED;
                    response.Message = "bad";
                    return Ok(response);
                }
            }
            catch(Exception ex)
            {
                response.Status = 503;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
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
                    response.Message = "ok";
                    return Ok(response);
                }
                else
                {
                    response.Status = 404;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "bad";
                    return Ok(response);
                }
            }
            catch(Exception ex)
            {
                response.Status = 503;
                response.State = ResponseStateEnum.SUCCESS;
                response.Message = "ok";
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
                response.Message = "ok";
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Status = 400;
                response.Message = "bad";
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
                    response.Message = "ok";
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 200;
                    return Ok(response);
                }
                response.Message = "bad";
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            catch
            {
                response.Message = "bad";
                response.State=ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }
    }
}
