using Domain.Common;
using Domain.Common.Response;
using Domain.Contracts.Services;
using Domain.Dtos.AnswerDtos;
using Domain.Entities;
using ExamSystemApi.Models.Request.Answer;
using ExamSystemApi.Models.Response.Academy;
using ExamSystemApi.Models.Response.Answer;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerServices answerServices;
        public AnswerController(IAnswerServices answerServices)
        {
            this.answerServices = answerServices;
        }
        [HttpPost]
        [Route("GetAllAnswer")]
        public async Task<IActionResult> GetAllAnswer()
        {
            var response = new ActionResponse<List<GetAnswerResponse>>();
            response.Data = new List<GetAnswerResponse>();
            try
            {
                var result = await answerServices.GetAllAnswer();
                if (result != null)
                {
                    response.Data = result.Adapt<List<GetAnswerResponse>>();
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;
                    response.Status = 200;
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_Calling;
                response.Status = 404;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
                response.Status = 404;
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("GetAnswer")]
        public async Task<IActionResult> GetAnswer()
        {
            var response = new ActionResponse<GetAnswerResponse>();
            response.Data = new GetAnswerResponse();
            try
            {
                var result = await answerServices.GetAnswer();
                if (result != null)
                {
                    response.Data = result.Adapt<GetAnswerResponse>();
                    response.State = ResponseStateEnum.SUCCESS;
                    response.Message = StaticStrings.S_Calling;
                    response.Status = 200;
                    return Ok(response);
                }
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.F_Calling;
                response.Status = 404;
            }
            catch
            {
                response.State = ResponseStateEnum.FAILED;
                response.Message = StaticStrings.ErrorInSystem;
                response.Status = 404;
            }
            return Ok(response);
        }
        [HttpPost]
        [Route("AddAnswer")]
        public async Task<IActionResult> AddAnswer(AddAnswerRequest request)
        {
            var response = new ActionResponse<AddAnswerResponse>();
            try
            {
                await answerServices.AddAnswer(request.Adapt<AddAnswerDetailDto>());
                response.Message = StaticStrings.S_CreateAnswer;
                response.State=ResponseStateEnum.SUCCESS;
                response.Status=200;
                return Ok(response);
            }
            catch
            {
                response.Message = StaticStrings.F_CreateAnswer;
                response.State = ResponseStateEnum.FAILED;
                response.Status = 400;
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("ChangeAnswer")]
        public async Task <IActionResult> ChangeAnswer(ChangeAnswerRequest request)
        {
            var response = new ActionResponse<ChangeAnswerResponse>();
            try
            {
                await answerServices.ChangeAnswer(request.Adapt<ChangeAnswerDetailDto>());
                response.Message = StaticStrings.S_CreateAnswer;
                response.State = ResponseStateEnum.SUCCESS;
                response.Status = 200;
            }
            catch
            {
                response.Message = StaticStrings.F_CreateAnswer;
                response.State = ResponseStateEnum.FAILED;
                response.Status = 400;
            }
            return Ok(response);
        }
    }
}
