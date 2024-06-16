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
        public static List<Backlog> backlogs = new List<Backlog>();
        public List<Backlog> GetAllBacklog()
        {
            throw new NotImplementedException();
        }
    }
}
