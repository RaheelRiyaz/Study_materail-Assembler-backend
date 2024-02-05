﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
