using Domain.Common.Response;
using Domain.Contracts.Services;
using ExamSystemApi.Models.Request.QuestionChoice;
using ExamSystemApi.Models.Response.QuestionChoice;
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
        public async Task<IActionResult> GetAllQuestionChoice(int skip, int take)
        {
            var response = new ActionResponse<List<GetQuestionChoiceResponse>>();
            response.Data = new List<GetQuestionChoiceResponse>();
            try
            {

            }
            catch
            {

            }
            return Ok(response);
        }
        [HttpGet]
        [Route("GetQuestionChoice")]
        public async Task<IActionResult> GetQuestionChoice(int id)
        {
            var response = new ActionResponse<GetQuestionChoiceResponse>();
            response.Data = new GetQuestionChoiceResponse();
            try
            {

            }
            catch
            {

            }
            return Ok(response);
        }
        [HttpGet]
        [Route("DeleteQuestionChoice")]
        public async Task<IActionResult> DeleteQuestionChoice([FromBody] DeleteQuestionChoiceRequest request)
        {
            var response = new ActionResponse<DeleteQuestionChoiceResponse>();
            try
            {

            }
            catch
            {

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

            }
            catch
            {

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

            }
            catch
            {

            }
            return Ok(response);
        }
    }
}
