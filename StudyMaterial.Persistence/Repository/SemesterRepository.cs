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
    public class SemesterRepository : BaseRepository<Semester> , ISemesterRepository
    {
        public SemesterRepository(StudyMaterialDbContext context):base(context) { }
    }
}
