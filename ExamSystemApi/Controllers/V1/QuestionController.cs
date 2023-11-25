using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.QuestionDtos;
using ExamSystemApi.Models.Request.Question;
using ExamSystemApi.Models.Response.Question;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionServices questionServices;
        public QuestionController(IQuestionServices questionServices)
        {
            this.questionServices = questionServices;
        }
        public async Task<IActionResult> GetQuestion(int id)
        {
            var response = new ActionResponse<GetQuestionsResponse>();
            response.Data = new GetQuestionsResponse(); 
            try
            {
                var result = await questionServices.GetQuestion(id);
                if(result != null)
                {
                    response.Message = "ok";
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Data = result.Adapt<GetQuestionsResponse>();
                    return Ok(response);
                }
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            catch
            {
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            return Ok(response);
        }
        public async Task<IActionResult> GetQuestions(int skip, int take)
        {
            var response = new ActionResponse<List<GetQuestionsResponse>>();
            response.Data = new List<GetQuestionsResponse>();
            try
            {
                var result = await questionServices.GetQuestions(skip, take);
                if(result != null)
                {
                    response.Message = "ok";
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Data = result.Adapt<List<GetQuestionsResponse>>();
                    return Ok(response);
                }
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            catch
            {
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            return Ok(response);
        }
        public async Task<IActionResult> DeleteQuestion(DeleteQuestionRequest request)
        {
            var response = new ActionResponse<DeleteQuestionResponse>();
            try
            {
                var result = await questionServices.DeleteQuestion(request.Adapt<DeleteQuestionDetailDto>());
                if (result)
                {
                    response.Message = "ok";
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    return Ok(response);
                }
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            catch
            {
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            return Ok(response);
        }
        public async Task<IActionResult> UpdateQuestion(UpdateQuestionRequest request)
        {
            var response = new ActionResponse<UpdateQuestionResponse>();
            try
            {
                var result = await questionServices.UpdateQuestion(request.Adapt<UpdateQuestionDetailDto>());
                if (result)
                {
                    response.Message = "ok";
                    response.Status = 200;
                    response.State = ResponseStateEnum.SUCCESS;
                    return Ok(response);
                }
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            catch
            {
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            return Ok(response);
        }
        
        public async Task<IActionResult> AddQuestion(AddQuestionRequest request)
        {
            var response = new ActionResponse<AddQuestionResponse>();
            try
            {
                await questionServices.AddQuestion(request.Adapt<AddQuestionDetailDto>());
                response.Message = "ok";
                response.Status = 200;
                response.State = ResponseStateEnum.SUCCESS;
                return Ok(response);
            }
            catch
            {
                response.Message = "bad";
                response.Status = 404;
                response.State = ResponseStateEnum.FAILED;
            }
            return Ok(response);
        }
    }
}
