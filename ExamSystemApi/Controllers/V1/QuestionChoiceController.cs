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
    }
}
