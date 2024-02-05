using StudyMaterial.Application.DTO_s;
using StudyMaterial.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Abstractions.IServices
{
    public interface ISubjectsService
    {
        Task<ApiResponse<IEnumerable<SubjectResponse>>> GetSubjects();
        Task<ApiResponse<IEnumerable<SubjectResponse>>> FilterSubjects(string term);
        Task<ApiResponse<SubjectResponse>> GetSubjectbyId(Guid id);
        Task<ApiResponse<SubjectResponse>> AddSubject(SubjectRequest model);
        Task<ApiResponse<SubjectResponse>> DeleteSubject(Guid id);
    }
}
