using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.QuestionChoice;
using Domain.Entities;
using ExamSystemApi.Models.Request.QuestionChoice;
using ExamSystemApi.Models.Response.QuestionChoice;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionChoiceController : ControllerBase
    {
        private readonly IQuestionChoiceServices questionChoiceServices;
        public QuestionChoiceController(IQuestionChoiceServices questionChoiceServices)
        {
            this.questionChoiceServices = questionChoiceServices;
        }
        [HttpGet]
        [Route("GetAllQuestionChoice")]
        public async Task<IActionResult> GetAllQuestionChoice(int questionId)
        {
            var response = new ActionResponse<List<GetQuestionChoiceResponse>>();
            response.Data = new List<GetQuestionChoiceResponse>();
            try
            {
                var result = await questionChoiceServices.GetAllQuestionChoice(questionId);
                if(result != null)
                {
                    response.Data = result.Adapt(response.Data);
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
        [HttpGet]
        [Route("GetQuestionChoice")]
        public async Task<IActionResult> GetQuestionChoice(int id, int questionId)
        {
            var response = new ActionResponse<GetQuestionChoiceResponse>();
            response.Data = new GetQuestionChoiceResponse();
            try
            {
                var result = await questionChoiceServices.GetQuestionChoice(id,questionId);
                if (result != null)
                {
                    response.Data = result.Adapt(response.Data);
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
        [HttpGet]
        [Route("DeleteQuestionChoice")]
        public async Task<IActionResult> DeleteQuestionChoice(int id)
        {
            var response = new ActionResponse<DeleteQuestionChoiceResponse>();
            try
            {
                var result = await questionChoiceServices.DeleteQuestionChoice(id);
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
        [HttpGet]
        [Route("UpdateQuestionChoice")]
        public async Task<IActionResult> UpdateQuestionChoice([FromBody] UpdateQuestionChoiceRequest request)
        {
            var response = new ActionResponse<UpdateQuestionChoiceResponse>();
            try
            {
                var result = await questionChoiceServices.UpdateQuestionChoice(request.Adapt<UpdateQuestionChoiceDetailDto>());
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
        [HttpGet]
        [Route("AddQuestionChoice")]
        public async Task<IActionResult> AddQuestionChoice([FromBody] AddQuestionChoiceRequest request)
        {
            var response = new ActionResponse<AddQuestionChoiceResponse>();
            try
            {
                await questionChoiceServices.AddQuestionChoice(request.Adapt<AddQuestionChoiceDetailDto>());
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
    }
}
