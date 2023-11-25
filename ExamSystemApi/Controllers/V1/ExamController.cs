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
        public async Task<IActionResult> CreateExam(CreateExamRequest request)
        {
            var response = new ActionResponse<CreateExamResponse>();
            try
            {
                await examServices.CreateExam(request.Adapt<CreateExamDetailDto>());
                response.Status = 200;
                response.State = ResponseStateEnum.SUCCESS;
                response.Message = "ok";
                return Ok(response);
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            return Ok(response);
        }
        public async Task<IActionResult> UpdateExam(UpdateExamRequest request)
        {
            var response = new ActionResponse<UpdateExamResponse>();
            try
            {
                var result = await examServices.UpdateExam(request.Adapt<UpdateExamDetailDto>());
                if (result)
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            return Ok(response);
        }
        public async Task<IActionResult> DeleteExam(DeleteExamRequest request)
        {
            var response = new ActionResponse<DeleteExamResponse>();
            try
            {
                var result = await examServices.DeleteExam(request.Adapt<DeleteExamDetailDto>());
                if (result)
                {
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = "ok";
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            return Ok(response);
        }
        
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
                    response.Message = "ok";
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            return Ok(response);
        }
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
                    response.Message = "ok";
                    return Ok(response);
                }
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            catch
            {
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
                response.Message = "bad";
            }
            return Ok(response);
        }
    }
}
