using AutoMapper;
using StudyMaterial.Application.DTO_s;
using StudyMaterial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Mappers
{
    public class SubjectMapper : Profile
    {
        public SubjectMapper()
        {
            CreateMap<Subject, SubjectResponse>();
            CreateMap<SubjectRequest, Subject>();
        }
    }


    public class SemesterMapper : Profile
    {
        public SemesterMapper()
        {
            CreateMap<Semester, SemesterResponse>();
            CreateMap<SemesterRequest, Semester>();
        }
    }


    public class ChapterMapper : Profile
    {
        public ChapterMapper()
        {
            CreateMap<Chapter, ChapterResponse>();
            CreateMap<ChapterRequest, Chapter>();
        }
    }
}
