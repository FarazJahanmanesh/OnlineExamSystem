using Domain.Contracts.Services;
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
        [Route("AddQuestionChoice")]
        public async Task<IActionResult> AddQuestionChoice()
        {

        }
        [HttpGet]
        [Route("GetAllQuestionChoice")]
        public async Task<IActionResult> GetAllQuestionChoice()
        {

        }
        [HttpGet]
        [Route("GetQuestionChoice")]
        public async Task<IActionResult> GetQuestionChoice()
        {

        }
        [HttpGet]
        [Route("DeleteQuestionChoice")]
        public async Task<IActionResult> DeleteQuestionChoice()
        {

        }
        [HttpGet]
        [Route("UpdateQuestionChoice")]
        public async Task<IActionResult> UpdateQuestionChoice()
        {

        }
    }
}
