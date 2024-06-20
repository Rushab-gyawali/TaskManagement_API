using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Entities
{
    public class Backlog
    {
        public string? BacklogId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ReportedBy { get; set; }
        public string? ReportedDate { get; set; }
        public int ProjectId { get; set; }
        public int IsActive { get; set; }
        public string? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UpdatedAt { get; set; }
    }
}
