﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Domain.Models
{
    public class Semester :BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
