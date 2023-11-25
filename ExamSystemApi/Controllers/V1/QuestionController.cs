using Domain.Contracts.Services;
using Domain.Dtos.QuestionDtos;
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
        GetQuestionsDetailDto
        public async Task<IActionResult> GetQuestion(int id)
        {

        }
        public Task<IActionResult> GetQuestions(int skip, int take)
        {

        }
        DeleteQuestionDetailDto
        public Task<IActionResult> DeleteQuestion( dto);
        public Task<bool> UpdateQuestion(UpdateQuestionDetailDto dto);
        public Task AddQuestion(AddQuestionDetailDto dto);
    }
}
