﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public int IsActive { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedAt { get; set; }

        //one to many
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
