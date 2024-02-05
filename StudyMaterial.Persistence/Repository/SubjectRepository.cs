using StudyMaterial.Application.Abstractions.IRepository;
using StudyMaterial.Domain.Models;
using StudyMaterial.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Infrastructure.Repository
{
    public class SubjectRepository : BaseRepository<Subject> , ISubjectRepository
    {
        public SubjectRepository(StudyMaterialDbContext context):base(context) { }
    }
}
