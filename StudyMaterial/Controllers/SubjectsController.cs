using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyMaterial.Application.Abstractions.IServices;
using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;

namespace StudyMaterial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectsService subjectsService;

        public SubjectsController(ISubjectsService subjectsService)
        {
            this.subjectsService = subjectsService;
        }

        [HttpGet]
        public async Task<ApiResponse<IEnumerable<SubjectResponse>>> GetAll()
        {
            return await subjectsService.GetSubjects();
        }

        [HttpGet("search/{term}")]
        public async Task<ApiResponse<IEnumerable<SubjectResponse>>> Search(string term)
        {
            return await subjectsService.FilterSubjects(term);
        }

        [HttpGet("{id:guid}")]
        public async Task<ApiResponse<SubjectResponse>> GetById(Guid id)
        {
            return await subjectsService.GetSubjectbyId(id);
        }


        [HttpPost()]
        public async Task<ApiResponse<SubjectResponse>> Add(SubjectRequest model)
        {
            return await subjectsService.AddSubject(model);
        }
    }
}
