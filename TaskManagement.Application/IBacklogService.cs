using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain;

namespace TaskManagement.Application
{
    //this is a use case
    public interface IBacklogService
    {
        List<Backlog> GetAllBacklog();
        Backlog CreateBacklog(Backlog backlog);
    }
}
