using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Abstractions.IServices
{
    public interface IChapterService
    {
        Task<ApiResponse<IEnumerable<ChapterResponse>>> GetChaptersBySubjectAndSemesterId(Guid subjectId, Guid semesterId);

        Task<ApiResponse<ChapterResponse>> AddChapter(ChapterRequest model);
    }
}
