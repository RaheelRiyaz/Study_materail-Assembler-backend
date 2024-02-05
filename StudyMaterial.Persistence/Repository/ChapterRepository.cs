using StudyMaterial.Application.Abstractions.IRepository;
using StudyMaterial.Domain.Models;
using StudyMaterial.Infrastructure.Data;
using StudyMaterial.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Persistence.Repository
{
    public class ChapterRepository : BaseRepository<Chapter>,IChapterRepository
    {
        public ChapterRepository(StudyMaterialDbContext context):base(context)
        {
        }
    }
}
