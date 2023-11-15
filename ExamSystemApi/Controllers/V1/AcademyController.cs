using Domain.Contracts.Services;
using Domain.Dtos.AcademyDtos;
using ExamSystemApi.Models.Request.Academy;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademyController : ControllerBase
    {
        #region ctor
        private readonly IExamServices examServices;
        private readonly IUserServices userServices;
        private readonly IAcademyServices academyServices;
        public AcademyController(IAcademyServices academyServices,
            IUserServices userServices,
            IExamServices examServices)
        {
            this.userServices = userServices;
            this.academyServices = academyServices;
            this.examServices = examServices;
        }
        #endregion
        [HttpGet]
        [Route("GetAllAcademy")]
        public async Task<IActionResult> GetAllAcademy()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetAcademy")]
        public async Task<IActionResult> GetAcademy()
        {
            return Ok();
        }
        [HttpPost]
        [Route("CreateAcademy")]
        public async Task<IActionResult> CreateAcademy()
        {
            await academyServices.AddAcademy();
            return Ok();
        }
        [HttpPost]
        [Route("DeleteAcademy")]
        public async Task<IActionResult> DeleteAcademy()
        {
            return Ok();
        }
        [HttpPost]
        [Route("UpdateAcademy")]
        public async Task<IActionResult> UpdateAcademy()
        {
            return Ok();
        }

        [HttpPost]
        [Route("CreateNewExam")]
        public async Task<IActionResult> CreateNewExam()
        {
            await examServices.CreateExam();
            return Ok();
        }
        [HttpPost]
        [Route("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AcademiesLogin")]
        public async Task<IActionResult> AcademiesLogin([FromBody]AcademiesLoginRequest request)
        {
            var result = await academyServices.AcademiesLogin(request.Adapt<AcademiesLoginDetailDto>());
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
