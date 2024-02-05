using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.DTO_s
{
    public class ChapterRequest
    {
        public int ChapterNo { get; set; }
        public Guid SubjectId { get; set; }
        public Guid SemesterId { get; set; }
        public string ChapterName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public IFormFile File { get; set; } = null!;
    }

    public class ChapterResponse 
    {
        public int ChapterNo { get; set; }
        public Guid SubjectId { get; set; }
        public string Title { get; set; } = null!;
        public Guid SemesterId { get; set; }
        public string ChapterName { get; set; } = null!;
        public Guid Id { get; set; }
        public string FilePath { get; set; } = null!;
    }
}
