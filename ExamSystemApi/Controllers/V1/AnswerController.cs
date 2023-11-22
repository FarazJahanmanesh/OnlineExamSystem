using Domain.Contracts.Services;
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
    }
}
