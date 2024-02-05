using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Domain.Models
{
    public class Chapter : BaseEntity
    {
        public int ChapterNo { get; set; }
        public string Title { get; set; } = null!;
        public Guid SubjectId { get; set; }
        public Guid SemesterId { get; set; }
        public string ChapterName { get; set; } = null!;
        public Guid FileId { get; set; } = Guid.NewGuid();
        public string FilePath { get; set; } = null!;

        [ForeignKey(nameof(SubjectId))]
        public Subject Subjects { get; set; } = null!;

        [ForeignKey(nameof(SemesterId))]
        public Semester Semesters { get; set; } = null!;
    }
}
