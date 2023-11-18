using Domain.Contracts.Services;
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
        [Route("CreateEXam")]
        public async Task<IActionResult> CreateEXam()
        {
            await examServices.CreateExam();
            return Ok();
        }
    }
}
