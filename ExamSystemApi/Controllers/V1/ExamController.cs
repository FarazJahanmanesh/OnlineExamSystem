using Domain.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    public class ExamController : Controller
    {
        private readonly IExamServices services;
        public ExamController(IExamServices services)
        {
            this.services= services;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
