using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.AcademyDtos;
using ExamSystemApi.Models.Request.Academy;
using ExamSystemApi.Models.Response.Academy;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademyController : ControllerBase
    {
        #region ctor
        private readonly IAcademyServices academyServices;
        public AcademyController(IAcademyServices academyServices)
        {
            this.academyServices = academyServices;
        }
        #endregion
        [HttpGet]
        [Route("GetAllAcademy")]
        public async Task<IActionResult> GetAllAcademies(GetAllAcademiesRequest request)
        {
            var response = new ActionResponse<List<GetAcademyResponse>>();
            response.Data = new List<GetAcademyResponse>();
            try
            {
                var result = await academyServices.GetAllAcademies(request.Skip, request.Take);
                if(result == null)
                {
                    response.Data = result.Adapt<List<GetAcademyResponse>>();
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                    response.Status = 200;
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
                response.Status = 404;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
                response.Status = 404;
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAcademy")]
        public async Task<IActionResult> GetAcademy(int id)
        {
            var response = new ActionResponse<GetAcademyResponse>();
            response.Data = new GetAcademyResponse();
            try
            {
                var result = await academyServices.GetAcademy(id);
                if (result == null)
                {
                    response.Data = result.Adapt<GetAcademyResponse>();
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                    response.Status = 200;
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
                response.Status = 404;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
                response.Status = 404;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("CreateAcademy")]
        public async Task<IActionResult> CreateAcademy(CreateAcademyRequest request)
        {
            var response = new ActionResponse<CreateAcademyResponse>();
            try
            {
                var result = await academyServices.AddAcademy(request.Adapt<CreateAcademyDetailDto>());
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
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("ChangeAcademyPassword")]
        public async Task<IActionResult> ChangeAcademyPassword(ChangeAcademyPasswordRequest dto)
        {
            var response = new ActionResponse<ChangeAcademyPasswordResponse>();
            try
            {
                var result = await academyServices.ChangeAcademyPassword(dto.Adapt<ChangeAcademyPasswordDetailDto>());
                if (result)
                {
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Status = 200;
                    response.Message = "ok";
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
        [Route("DeleteAcademy")]
        public async Task<IActionResult> DeleteAcademy(int id)
        {
            var response = new ActionResponse<DeleteAcademyResponse>();
            try
            {
                var result = await academyServices.DeleteAcademy(id);
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
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateAcademy")]
        public async Task<IActionResult> UpdateAcademy(UpdateAcademyRequest request)
        {
            var response = new ActionResponse<UpdateAcademyResponse>();
            try
            {
                var result = await academyServices.UpdateAcademy(request.Adapt<UpdateAcademyDetailDto>());
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
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("AcademiesLogin")]
        public async Task<IActionResult> AcademiesLogin([FromBody]AcademiesLoginRequest request)
        {
            var response = new ActionResponse<AcademiesLoginResponse>();
            try
            {
                var result = await academyServices.AcademiesLogin(request.Adapt<AcademiesLoginDetailDto>());
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
                response.State = ResponseStateEnum.FAILED;
                response.Status = 404;
            }
            return Ok(response);
        }
    }
}
