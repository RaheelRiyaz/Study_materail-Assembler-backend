using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.DTO_s
{
    public class SubjectResponse : SubjectRequest
    {
        public Guid Id { get; set; }
    }

    public class SubjectRequest
    {
        public string Name { get; set; } = null!;
    }
}
