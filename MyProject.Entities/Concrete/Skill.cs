﻿using MyProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Entities.Concrete
{
    public class Skill : IEntity
    {
        public int SkillId { get; set; }
        public string SkillItem { get; set; }
        public int SkillItemPercent { get; set; }
    }
}
