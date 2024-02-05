using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudyMaterial.Application.Abstractions.IRepository;
using StudyMaterial.Infrastructure.Data;
using StudyMaterial.Infrastructure.Repository;
using StudyMaterial.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Persistence
{
    public static class AssemblyReference
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<StudyMaterialDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(nameof(StudyMaterialDbContext)));
            });

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<IChapterRepository, ChapterRepository>();
            return services;
        }
    }
}
