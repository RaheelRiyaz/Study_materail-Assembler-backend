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
    public class SubjectsService : ISubjectsService
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly IMapper mapper;

        public SubjectsService(ISubjectRepository subjectRepository ,IMapper mapper)
        {
            this.subjectRepository = subjectRepository;
            this.mapper = mapper;
        }
        public async Task<ApiResponse<SubjectResponse>> AddSubject(SubjectRequest model)
        {
            var subject = mapper.Map<Subject>(model);
            var res = await subjectRepository.AddAsync(subject);

            if(res > 0)
            {
                return ApiResponse<SubjectResponse>.SuccessResponse(mapper.Map<SubjectResponse>(subject));
            }

            return ApiResponse<SubjectResponse>.ErrorResponse();

        }

        public Task<ApiResponse<SubjectResponse>> DeleteSubject(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<IEnumerable<SubjectResponse>>> FilterSubjects(string term)
        {
           var subjects = await subjectRepository.Filter(_=>_.Name.StartsWith(term));

                return ApiResponse<IEnumerable<SubjectResponse>>.SuccessResponse(mapper.Map<IEnumerable<SubjectResponse>>(subjects));

        }

        public async Task<ApiResponse<SubjectResponse>> GetSubjectbyId(Guid id)
        {
            var subject = await subjectRepository.GetByIdAsync(id);

            if (subject is not null)
            {
                return ApiResponse<SubjectResponse>.SuccessResponse(mapper.Map<SubjectResponse>(subject));
            }

            return ApiResponse<SubjectResponse>.ErrorResponse();
        }

        public async Task<ApiResponse<IEnumerable<SubjectResponse>>> GetSubjects()
        {
            var subjects = await subjectRepository.GetAllAsync();

            if (subjects.Any())
            {
                return ApiResponse<IEnumerable<SubjectResponse>>.SuccessResponse(mapper.Map<IEnumerable<SubjectResponse>>(subjects));
            }

            return ApiResponse<IEnumerable<SubjectResponse>>.ErrorResponse("No Subject found");
        }
    }
}
