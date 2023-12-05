using Domain.Common;
using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.ExamDtos;
using ExamSystemApi.Models.Request.Exam;
using ExamSystemApi.Models.Response.Exam;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    public class ExamController : Controller
    {
        private readonly IExamServices examServices;
        public ExamController(IExamServices examServices)
        {
            this.examServices = examServices;
        }
        [HttpPost]
        [Route("CreateExam")]
        public async Task<IActionResult> CreateExam([FromBody] CreateExamRequest request)
        {
            var response = new ActionResponse<CreateExamResponse>();
            try
            {
                await examServices.CreateExam(request.Adapt<CreateExamDetailDto>());
                response.Status = 200;
                response.State = ResponseStateEnum.SUCCESS;
                response.Message = StaticStrings.S_CreateUser;
                return Ok(response);
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_CreateUser;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateExam")]
        public async Task<IActionResult> UpdateExam([FromBody] UpdateExamRequest request)
        {
            var response = new ActionResponse<UpdateExamResponse>();
            try
            {
                var result = await examServices.UpdateExam(request.Adapt<UpdateExamDetailDto>());
                if (result)
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_UpdateExam;
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_UpdateExam;
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("DeleteExam")]
        public async Task<IActionResult> DeleteExam([FromBody] DeleteExamRequest request)
        {
            var response = new ActionResponse<DeleteExamResponse>();
            try
            {
                var result = await examServices.DeleteExam(request.Adapt<DeleteExamDetailDto>());
                if (result)
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_DeleteUser;
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_DeleteUser;
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpGet]
        [Route("ShowExams")]
        public async Task<IActionResult> ShowExams(int skip, int take)
        {
            var response = new ActionResponse<List<ShowExamResponse>>();
            response.Data = new List<ShowExamResponse>();
            try
            {
                var result = await examServices.ShowExams(skip, take);
                if (result != null)
                {
                    response.Data = result.Adapt<List<ShowExamResponse>> ();
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_Calling;
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
        [HttpGet]
        [Route("ShowExam")]
        public async Task<IActionResult> ShowExam(int id)
        {
            var response = new ActionResponse<ShowExamResponse>();
            response.Data= new ShowExamResponse();
            try
            {
                var result = await examServices.ShowExam(id);
                if (result != null)
                {
                    response.Data = result.Adapt<ShowExamResponse>();
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ExamNotFound;
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
            }
            return Ok(response);
        }
    }
}
