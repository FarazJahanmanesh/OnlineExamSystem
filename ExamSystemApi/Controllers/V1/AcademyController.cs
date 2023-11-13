using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamSystemApi.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademyController : ControllerBase
    {
        #region ctor
        //private readonly IAcademyServices 
        public AcademyController()
        {

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
        [Route("AcademiesLogin")]
        public async Task<IActionResult> AcademiesLogin()
        {
            return Ok();
        }
    }
}
