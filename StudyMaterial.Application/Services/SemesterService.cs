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
    public class SemesterService : ISemesterService
    {
        private readonly ISemesterRepository semesterRepository;
        private readonly IMapper mapper;

        public SemesterService(ISemesterRepository semesterRepository ,IMapper mapper)
        {
            this.semesterRepository = semesterRepository;
            this.mapper = mapper;
        }

        public async Task<ApiResponse<SemesterResponse>> AddSemester(SemesterRequest model)
        {
            var sem = mapper.Map<Semester>(model);
            var res = await semesterRepository.AddAsync(sem);

            if(res > 0)
            {
                return ApiResponse<SemesterResponse>.SuccessResponse(mapper.Map<SemesterResponse>(sem));
            }

            return ApiResponse<SemesterResponse>.ErrorResponse();

        }

        public Task<ApiResponse<SemesterResponse>> DeleteSemester(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<SemesterResponse>> GetSemesterbyId(Guid id)
        {
            var sem = await semesterRepository.GetByIdAsync(id);

            if(sem is not null)
            {
                return ApiResponse<SemesterResponse>.SuccessResponse(mapper.Map<SemesterResponse>(sem));
            }
            return ApiResponse<SemesterResponse>.ErrorResponse("No semester found");

        }

        public async Task<ApiResponse<IEnumerable<SemesterResponse>>> GetSemesters()
        {
            var sems = (await semesterRepository.GetAllAsync()).OrderBy(_ => _.CreatedOn);

            if (sems.Any())
            {
                return ApiResponse<IEnumerable<SemesterResponse>>.SuccessResponse(mapper.Map<IEnumerable<SemesterResponse>>(sems));
            }

            return ApiResponse<IEnumerable<SemesterResponse>>.ErrorResponse("No semester found");

        }
    }
}
