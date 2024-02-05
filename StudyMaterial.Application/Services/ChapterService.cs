using AutoMapper;
using StudyMaterial.Application.Abstractions.IRepository;
using StudyMaterial.Application.Abstractions.IServices;
using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;
using StudyMaterial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Services
{
    public class ChapterService : IChapterService
    {
        private readonly IChapterRepository chapterRepository;
        private readonly IMapper mapper;
        private readonly IStorageService storageService;

        public ChapterService(IChapterRepository chapterRepository ,IMapper mapper ,IStorageService storageService)
        {
            this.chapterRepository = chapterRepository;
            this.mapper = mapper;
            this.storageService = storageService;
        }
        public async Task<ApiResponse<ChapterResponse>> AddChapter(ChapterRequest model)
        {
            var filepath = await storageService.SaveFileAsync(model.File);
            var chapter = mapper.Map<Chapter>(model);
            chapter.FilePath = filepath;
            var res = await chapterRepository.AddAsync(chapter);

            if(res > 0)
            {
                return ApiResponse<ChapterResponse>.SuccessResponse(mapper.Map<ChapterResponse>(chapter));
            }

            return ApiResponse<ChapterResponse>.ErrorResponse();
        }

        public async Task<ApiResponse<IEnumerable<ChapterResponse>>> GetChaptersBySubjectAndSemesterId(Guid subjectId, Guid semesterId)
        {
            var chapters = await chapterRepository.Filter(_=>_.SubjectId == subjectId && _.SemesterId == semesterId);

            if (chapters.Any())
            {
                return ApiResponse<IEnumerable<ChapterResponse>>.SuccessResponse(mapper.Map<IEnumerable<ChapterResponse>>(chapters));
            }

            return ApiResponse<IEnumerable<ChapterResponse>>.ErrorResponse("No Chapter Found");
        }
    }
}
