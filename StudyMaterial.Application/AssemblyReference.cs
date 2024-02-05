using Microsoft.Extensions.DependencyInjection;
using PoultryFarming.Application.Services;
using StudyMaterial.Application.Abstractions.IServices;
using StudyMaterial.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application
{
    public static class AssemblyReference
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,string webRootPath)
        {
            services.AddScoped<ISubjectsService,SubjectsService>();
            services.AddScoped<ISemesterService,SemesterService>();
            services.AddScoped<IChapterService,ChapterService>();
            services.AddSingleton<IStorageService>(new StorageService(webRootPath));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
