using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyMaterial.Application.Abstractions.IServices;
using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;

namespace StudyMaterial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService chapterService;

        public ChapterController(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        [HttpPost]
        public async Task<ApiResponse<ChapterResponse>> AddChapter([FromForm] ChapterRequest model)
        {
            return await chapterService.AddChapter(model);
        }

        [HttpGet("{subjectId:guid}/{semesterId:guid}")]
        public async Task<ApiResponse<IEnumerable<ChapterResponse>>> GetChapter(Guid subjectId,Guid semesterId)
        {
            return await chapterService.GetChaptersBySubjectAndSemesterId(subjectId, semesterId);
        }
    }
}
