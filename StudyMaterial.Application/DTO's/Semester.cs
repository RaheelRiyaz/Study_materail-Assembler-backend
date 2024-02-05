using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.DTO_s
{
    public class SemesterRequest
    {
        public string Name { get; set; } = null!;
    }


    public class SemesterResponse : SemesterRequest
    {
        public Guid Id { get; set; }
    }
}
