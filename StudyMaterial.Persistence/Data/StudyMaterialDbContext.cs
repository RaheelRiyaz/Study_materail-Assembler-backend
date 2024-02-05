using Microsoft.EntityFrameworkCore;
using StudyMaterial.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Infrastructure.Data
{
    public class StudyMaterialDbContext : DbContext
    {
        public StudyMaterialDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Chapter> chapters { get; set; }
    }
}
