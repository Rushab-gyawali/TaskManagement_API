using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain
{
    public class Backlog
    {
        public string? BacklogId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ReportedBy { get; set; }
        public string? ReportedDate { get; set; }
    }
}
