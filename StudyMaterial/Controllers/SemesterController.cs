using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyMaterial.Application.Abstractions.IServices;
using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;

namespace StudyMaterial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService semesterService;

        public SemesterController(ISemesterService semesterService)
        {
            this.semesterService = semesterService;
        }
        [HttpGet]
        public async Task<ApiResponse<IEnumerable<SemesterResponse>>> GetAll()
        {
            return await semesterService.GetSemesters();
        }


        [HttpGet("{id:guid}")]
        public async Task<ApiResponse<SemesterResponse>> GetById(Guid id)
        {
            return await semesterService.GetSemesterbyId(id);
        }


        [HttpPost]
        public async Task<ApiResponse<SemesterResponse>> Add(SemesterRequest model)
        {
            return await semesterService.AddSemester(model);
        }
    }
}
