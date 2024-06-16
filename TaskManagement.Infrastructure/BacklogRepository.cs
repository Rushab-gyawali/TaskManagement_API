using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application;
using TaskManagement.Domain;

namespace TaskManagement.Infrastructure
{
    public class BacklogRepository : IBacklogRepository
    {
        public static List<Backlog> backlogs = new List<Backlog>()
        {
            new Backlog { BacklogId = "1", Name = "sd", Description = "asdfa", ReportedBy = new DateTime().ToString(), ReportedDate = new DateTime().ToString() },
            new Backlog { BacklogId = "2", Name = "gfhj", Description = "hdfgsf", ReportedBy = new DateTime().ToString(), ReportedDate = new DateTime().ToString() }
        };

        public List<Backlog> GetAllBacklog()
        {
            return backlogs;
        }
    }
}
