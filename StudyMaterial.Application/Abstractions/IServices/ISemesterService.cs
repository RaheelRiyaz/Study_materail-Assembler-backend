using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Abstractions.IServices
{
    public interface ISemesterService
    {
        Task<ApiResponse<IEnumerable<SemesterResponse>>> GetSemesters();
        Task<ApiResponse<SemesterResponse>> GetSemesterbyId(Guid id);
        Task<ApiResponse<SemesterResponse>> AddSemester(SemesterRequest model);
        Task<ApiResponse<SemesterResponse>> DeleteSemester(Guid id);
    }
}
